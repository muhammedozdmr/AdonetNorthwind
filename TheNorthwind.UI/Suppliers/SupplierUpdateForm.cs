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

namespace TheNorthwind.UI.Suppliers
{
    public partial class SupplierUpdateForm : SupplierEditForm
    {
        private SupplierService _supplierService = new SupplierService();
        private int _supplierId;
        public SupplierUpdateForm(int supplierId)
        {
            InitializeComponent();
            _supplierId = supplierId;
        }

        private void SupplierUpdateForm_Load(object sender, EventArgs e)
        {
            var supplier = _supplierService.GetById(_supplierId);
            txtCompanyName.Text = supplier.CompanyName;
            txtContactName.Text = supplier.ContactName;
            txtContactTitle.Text = supplier.ContactTitle;
            txtAddress.Text = supplier.Address;
            txtCity.Text = supplier.City;
            txtRegion.Text = supplier.Region;
            txtPostalCode.Text = supplier.PostalCode;
            txtCountryName.Text = supplier.Country;
            txtPhone.Text = supplier.Phone;
            txtFax.Text = supplier.Fax;
            txtHomePage.Text = supplier.HomePage;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier()
            {
                Id = _supplierId,
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,    
                Address = txtAddress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountryName.Text,
                Phone = txtPhone.Text,
                Fax = txtFax.Text,
                HomePage = txtHomePage.Text
            };

            var result = _supplierService.Update(supplier);
            if (result.IsSucces)
            {
                MessageBox.Show(result.Message);
                ((Form1)MdiParent).RefreshActiveCategoryListForm();
                Close();
            }
            
            else
            {
                MessageBox.Show(result.Message);
            }
        }

    }
}
