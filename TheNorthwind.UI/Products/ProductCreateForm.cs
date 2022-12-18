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
using TheNorthwind.DataAccess;

namespace TheNorthwind.UI.Products
{
    public partial class ProductCreateForm : Form
    {
        public ProductCreateForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                Name = txtName.Text,
                SupplierId = (int)cmbSupplier.SelectedValue,
                CategoryId = (int)cmbCategory.SelectedValue,
                QuantityPerUnit = txtQuantityPerUnit.Text,
                UnitPrice = numUnitPrice.Value,
                UnitsInStock = (short)numUnitsInStock.Value,
                UnitsOnOrder = (short)numUnitsOnOrder.Value,
                ReorderLevel = (short)numReorderLevel.Value,
                Discontinued = chkDiscontinued.Checked
            };
            using (SqlConnection sqlConnection = new SqlConnection(DbSettings.ConnectionString))
            //bişey.Create() metotlarına Factory Metot(factory pattern) denir
            using (var sqlCommand = sqlConnection.CreateCommand())
            {
                try
                {
                    sqlCommand.CommandText = @"
INSERT INTO [dbo].[Products]
           ([ProductName],[SupplierID],[CategoryID],[QuantityPerUnit],[UnitPrice]
           ,[UnitsInStock],[UnitsOnOrder],[ReorderLevel],[Discontinued])
     VALUES
           (@productName,@supplierId,@categoryId,@quantityPerUnit,
           @unitPrice,@unitsInStock,@unitsOnOrder,@reorderLevel,@discontinued)";

                    sqlCommand.Parameters.AddWithValue("productName", product.Name);
                    sqlCommand.Parameters.AddWithValue("supplierId", product.SupplierId);
                    sqlCommand.Parameters.AddWithValue("categoryId", product.CategoryId);
                    sqlCommand.Parameters.AddWithValue("quantityPerUnit", product.QuantityPerUnit);
                    sqlCommand.Parameters.AddWithValue("unitPrice", product.UnitPrice);
                    sqlCommand.Parameters.AddWithValue("unitsInStock", product.UnitsInStock);
                    sqlCommand.Parameters.AddWithValue("unitsOnOrder", product.UnitsOnOrder);
                    sqlCommand.Parameters.AddWithValue("reorderLevel", product.ReorderLevel);
                    sqlCommand.Parameters.AddWithValue("discontinued", product.Discontinued);

                    sqlConnection.Open();
                    //Veri okumuyorum veri gönderiyorum bu yüzden sorgu değil NonQuery olarak Execute yapıyorum
                    var affectedRows = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Kaydetme başarılı");
                        foreach(var mdiChild in MdiParent.MdiChildren)
                        {
                            if(mdiChild is ProductListForm)
                            {
                                var productListForm = (ProductListForm)mdiChild;
                                productListForm.RefreshForm();
                            }
                        }
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Dön bebeğim..");
                    }

                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }

        private void ProductCreateForm_Load(object sender, EventArgs e)
        {
            var categoryService = new CategoryService();
            var categories = categoryService.GetAll();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name"; //Classın propertylerindeki isim displaymember comboboxta görünecek isimler
            cmbCategory.ValueMember = "Id"; //id ise comboboxta ki seçime göre işaretlenecek id değeri

            var supplierService = new SupplierService();
            var suppliers = supplierService.GetAll();
            cmbSupplier.DataSource = suppliers;
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "Id";
        }
    }
}

//TODO: Hocanın kodları incele formload kısmını özellikle
