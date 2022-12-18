using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheNorthwind.Business;

namespace TheNorthwind.UI.Products
{
    public partial class ProductListForm : Form
    {
        private ProductService _productService = new ProductService();
        private const string ConnectionString = "Server=.;Database=Northwind;Integrated Security=true;";

        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            using (var sqlConnection = new SqlConnection(ConnectionString))
            using (var sqlCommand = sqlConnection.CreateCommand())
            {
                try
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = @"
select 
ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,
UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued from Products";
                    sqlConnection.Open();
                    var productList = new List<Product>();
                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            var product = new Product()
                            {
                                Id = (int)dataReader["ProductID"],
                                Name = (string)dataReader["ProductName"],

                                //Eğer dataReader["HÜCRE_ADI"] değeri veritabanından NULL
                                //değer geliyorsa aşağıdaki satır runtime'da hata fırlatacaktır.,
                                //Result Set'ten NULL gelebilecek değerleri aşağıdaki gibi doğrudan cast etme işlemi yapamam

                                //SupplierId = (int)dataReader["SupplierID"], null değer barındırdığı için hata verir

                                //Result Set'ten NULL gelebilecek değerleri aşağıdaki örneklerde olduğu gibi
                                //kontrollü bir şekilde karşılamam gerekiyor

                                //SupplierId = dataReader["SupplierID"] == DBNull.Value
                                //? default
                                //: (int)dataReader["SupplierID"],

                                //SupplierId = dataReader.IsDBNull("SupplierID")
                                //? default(int?)
                                //: (int)dataReader["SupplierID"],

                                SupplierId = dataReader.IsDBNull("SupplierID")
                                ? null //eğer hata alrsan (int?)null olarak yazılmaası gerek .Net5 yada .Net6 da bu bazen oluyor
                                       //yada direkt default
                                : dataReader.GetInt32("SupplierID"),

                                //TODO: Extension method geliştirilecek //Bunun la Todo View da TaskListte gösteriliyor bir not ekleme gibi
                                //SupplierId = dataReader.GetNullableInt2("SupplierID");


                                CategoryId = dataReader.IsDBNull("CategoryID") ? default : dataReader.GetInt32("CategoryID"),
                                QuantityPerUnit = (string)dataReader["QuantityPerUnit"],
                                UnitPrice = dataReader.IsDBNull("UnitPrice") ? default : dataReader.GetDecimal("UnitPrice"),
                                UnitsInStock = dataReader["UnitsInStock"] == DBNull.Value ? default : (short)dataReader["UnitsInStock"],
                                UnitsOnOrder = dataReader["UnitsOnOrder"] != DBNull.Value ? (short)dataReader["UnitsOnOrder"] : default,
                                ReorderLevel = !dataReader.IsDBNull("ReorderLevel") ? (short)dataReader["ReorderLevel"] : default,
                                Discontinued = (bool)dataReader["Discontinued"],
                            };
                            productList.Add(product);
                        }
                        sqlConnection.Close();

                        grdProduct.DataSource = productList;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata aldın\n" + ex.ToString());
                }
            }
        }
        private void NullableTest()
        {
            //Normla Int32 değişken, yani null değer kabul edemez
            int number = 10;
            number = 0;
            number = default;
            //number = null; //hata verdi mesela
            //Yukarıdaki satır doğal olarak bir derleme hatasına sebep olur


            //nullableNumber isimli değişken null değer atanabilir bir Int32
            //Uzuun uzun yazım şekli Nullable<int>
            //Kısaca int?
            Nullable<int> nullableNumber = 10;
            nullableNumber = 0;
            nullableNumber = null;
            nullableNumber = default; //int? nullable Int32 tiplerin default(varsayılan) değeri 0 değil null değeridir!!


            //int? tipindeki bir değişkene int tipindeki bir değişkenin değerini 
            //doğrudan atayabilirim
            //meali; null geçilebilir bir değişkene null geçilemeyen bir değişkenin değerini atayabilirim
            nullableNumber = number;

            //int tipindeki bir değişkene int?(yani nullable) tipindeki bir değişkenden değeri doğrudan atama yapamam
            //Burada bir nevi kontrollü bir atama işlemi yapılması gerekiyor.
            //.HasValue => Bu değişkenin değeri var mı ? (yani null değilse true)
            //.Value => int tipinde değeri döndürür
            number = nullableNumber.HasValue
                ? nullableNumber.Value
                : default;

            //nullable değişkeninin .Value ile değerini doğrudan okumak sakncaldır.
            //Eğer değişkenin değeri null ise bu işlem Eception fırlatılmasına sebep olur
            number = nullableNumber.Value; //hata verebilir eğer nullableNumber null ise

            int? nullableNumber2 = 10;
            nullableNumber2 = null;

            //sadece int? değil, diğer tüm değer tipli (yani özünde struct olan) tipler
            //nullable olarak tanımlanabilir
            //Örneğin short?
            short? unitsInStock = 20;
            unitsInStock = null;

            var product = new Product();

            //Nullable tipler yalnızca değişkenlerde değil, Property, Field, Method(dönüş tipi) gibi bir tipe sahip 
            //herhangi bir birimde kullanılabilir
            product.SupplierId = null;
            product.CategoryId = null;
        }

        private void ProductListForm_Load_1(object sender, EventArgs e)
        {
            var productService = new ProductService();
            var products = productService.GetAll();
            grdProduct.DataSource = products;
        }

        private void menuUpdateProduct_Click(object sender, EventArgs e)
        {
            if (grdProduct.SelectedRows.Count > 0)
            {
                var product = (Product)grdProduct.SelectedRows[0].DataBoundItem;
                var productUpdateForm = new ProductUpdateForm(product.Id);
                productUpdateForm.MdiParent = this.MdiParent;
                productUpdateForm.Show();
                productUpdateForm.FormClosed += ProductUpdateForm_FormClosed;
            }
        }

        private void ProductUpdateForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            RefreshForm();
        }

        private void menuDeleteProduct_Click(object sender, EventArgs e)
        {
            if (grdProduct.SelectedRows.Count > 0)
            {
                var product = (Product)grdProduct.SelectedRows[0].DataBoundItem;
                var result = MessageBox.Show($"{product.Name} isimli kategoriyi silmek istediğinize emin misiniz ?",
                    "Dikkat!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //TODO: servisten Delete metodu çağır !!
                    MessageBox.Show("Silindi !");
                    _productService.Remove(product);
                    foreach (var mdiChild in MdiParent.MdiChildren)
                    {
                        if (mdiChild is ProductListForm)
                        {
                            ((ProductListForm)mdiChild).RefreshForm();
                        }
                    }

                }

                var deleteCategory = _productService.Remove(product);
            }
        }

        private void grdProduct_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                grdProduct.Rows[e.RowIndex].Selected = true;
            }
        }

        public void RefreshForm()
        {
            var product = _productService.GetAll();
            grdProduct.DataSource = product;
        }
    }
}

