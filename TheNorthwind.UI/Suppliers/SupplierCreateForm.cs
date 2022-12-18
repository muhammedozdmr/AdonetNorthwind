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
    public partial class SupplierCreateForm : SupplierEditForm
    {
        private SupplierService _supplierService = new SupplierService();
        public SupplierCreateForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier()
            {
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
            var result = _supplierService.Create(supplier);
            ProcessCommandResult(result);
        }
        private void ProcessCommandResult(CommandResult result)
        {
            if (result.IsSucces)
            {
                foreach (var mdiChild in MdiParent.MdiChildren)
                {
                    if (mdiChild is SupplierListForm)
                    {
                        var supplierListForm = (SupplierListForm)mdiChild;
                        supplierListForm.RefreshForm();
                    }
                }
                var dialogResult = MessageBox.Show("Yeni bir kayıt eklemek istiyor musunuz ?", result.Message, 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    ClearForm();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                var dialogResult = MessageBox.Show(
                    "Hata mesajını görüntülemek ister misiniz?", result.Message, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
        }
    }
}
