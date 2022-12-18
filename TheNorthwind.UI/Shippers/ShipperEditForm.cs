using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNorthwind.UI.Shippers
{
    public partial class ShipperEditForm : Form
    {
        public ShipperEditForm()
        {
            InitializeComponent();
        }
        protected void ClearForm()
        {
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }
    }
}
