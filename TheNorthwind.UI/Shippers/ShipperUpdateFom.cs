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

namespace TheNorthwind.UI.Shippers
{
    public partial class ShipperUpdateFom : ShipperEditForm
    {
        private ShipperService _shipperService = new ShipperService();
        private int _shipperId;
        public ShipperUpdateFom(int shipperId)
        {
            InitializeComponent();
            _shipperId = shipperId;
        }

        private void ShipperUpdateFom_Load(object sender, EventArgs e)
        {
            var shipper = _shipperService.GetById(_shipperId);
            txtName.Text = shipper.Name;
            txtPhone.Text = shipper.Phone;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var shipper = new Shipper()
            {
                Id = _shipperId,
                Name = txtName.Text,
                Phone = txtPhone.Text
            };
            var result = _shipperService.Update(shipper);
            if (result.IsSucces)
            {
                MessageBox.Show(result.Message);
                ((Form1)MdiParent).RefreshActiveShippersListForm();
                Close();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
