using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNorthwind.UI.Suppliers
{
    public partial class SupplierEditForm : Form
    {
        public SupplierEditForm()
        {
            InitializeComponent();
        }
        protected void ClearForm()
        {
            txtCompanyName.Text = string.Empty;
            txtContactName.Text = string.Empty;
            txtContactTitle.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtRegion.Text = string.Empty;
            txtPostalCode.Text = string.Empty;
            txtCountryName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtHomePage.Text = string.Empty;
        }
    }
}
