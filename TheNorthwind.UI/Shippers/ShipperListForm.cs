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
    public partial class ShipperListForm : Form
    {
        private ShipperService _shipperService = new ShipperService();
        public ShipperListForm()
        {
            InitializeComponent();
        }

        private void menuUpdateShipper_Click(object sender, EventArgs e)
        {
            if (grdShippersListForm.SelectedRows.Count > 0)
            {
                var shipper = (Shipper)grdShippersListForm.SelectedRows[0].DataBoundItem;
                var shipperUpdateForm = new ShipperUpdateFom(shipper.Id);
                shipperUpdateForm.MdiParent = this.MdiParent;
                shipperUpdateForm.Show();
                //shipperUpdateForm.FormClosed += ShipperUpdateForm_FormClosed;
            }
        }

        //private void ShipperUpdateForm_FormClosed(object? sender, FormClosedEventArgs e)
        //{
        //    RefreshForm();
        //}

        private void menuDeleteShipper_Click(object sender, EventArgs e)
        {
            //TODO: Shipper refreshde problem var
            var shipper = (Shipper)grdShippersListForm.SelectedRows[0].DataBoundItem;
            var result = MessageBox.Show($"{shipper.Name} isimli kargo firmasını silmek istediğinize emin misiniz ?","Dikkat !",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                MessageBox.Show("Silindi");
                _shipperService.Delete(shipper);
                ((Form1)MdiParent).RefreshActiveShippersListForm();
            }
        }
        public void RefreshForm()
        {
            var shippers = _shipperService.GetAll();
            grdShippersListForm.DataSource = shippers;
        }

        private void grdShippersListForm_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                grdShippersListForm.Rows[e.RowIndex].Selected = true;
            }
        }

        private void ShipperListForm_Load(object sender, EventArgs e)
        {
            var shippers = _shipperService.GetAll();
            grdShippersListForm.DataSource = shippers;
        }
    }
}
