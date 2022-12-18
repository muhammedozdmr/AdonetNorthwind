using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheNorthwind.Business;

namespace TheNorthwind.UI.Products
{
    public partial class ProductUpdateForm : Form
    {
        private readonly ProductService _productService = new ProductService();
        private readonly SupplierService _supplierService = new SupplierService();
        private readonly CategoryService _categoryService = new CategoryService();
        private int _productId;
        public ProductUpdateForm(int productId)
        {
            InitializeComponent();
            _productId = productId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                Id = _productId,
                Name = txtName.Text,
                SupplierId = (int)cmbSupplier.SelectedValue,
                CategoryId = (int)cmbCategory.SelectedValue,
                QuantityPerUnit = txtQuantityPerUnit.Text,
                UnitPrice = numUnitPrice.Value,
                UnitsInStock =(short)numUnitsInStock.Value,
                UnitsOnOrder = (short)numUnitsOnOrder.Value,
                ReorderLevel = (short)numReorderLevel.Value,
                Discontinued = chkDiscontinued.Checked,
            };

            var result = _productService.Update(product);
            if (result.IsSucces)
            {
                MessageBox.Show(result.Message);
                Close();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = _categoryService.GetAll();
            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Name";

            cmbSupplier.DataSource = _supplierService.GetAll();
            cmbSupplier.ValueMember = "Id";
            cmbSupplier.DisplayMember = "CompanyName";

            var product = _productService.Find(_productId);
            txtName.Text = product.Name;
            cmbSupplier.SelectedValue = (int)product.SupplierId;
            cmbCategory.SelectedValue = (int)product.CategoryId;
            txtQuantityPerUnit.Text = product.QuantityPerUnit;
            numUnitPrice.Value = product.UnitPrice.HasValue ? product.UnitPrice.Value : 0;
            numUnitsInStock.Value = product.UnitsInStock.HasValue ? product.UnitsInStock.Value :0;
            numUnitsOnOrder.Value = product.UnitsOnOrder.HasValue ? product.UnitsOnOrder.Value : 0;
            numReorderLevel.Value = product.ReorderLevel.HasValue ? product.ReorderLevel.Value : 0;
            chkDiscontinued.Checked = product.Discontinued;
        }
    }
}
