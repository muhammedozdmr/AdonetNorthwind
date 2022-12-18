using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNorthwind.UI.Products
{
    public partial class UpdateUnitPricesConfirmationBox : Form
    {
        //TODO: Buralara hocanın kodundan bak
        //TODO: Formun ve gridin boyutu düzenlenmeli, yamuk duruyor
        private readonly List<Product> _products;
        public UpdateUnitPricesConfirmationBox(List<Product>products)
        {
            InitializeComponent();
            _products = products;
        }

        private void UpdateUnitPricesConfirmationBox_Load(object sender, EventArgs e)
        {
            grdProduct.DataSource = _products;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
