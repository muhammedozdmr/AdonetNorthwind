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
    public partial class SupplierListForm : Form
    {
        private SupplierService _supplierService = new SupplierService();
        public SupplierListForm()
        {
            InitializeComponent();
        }

        private void SupplierListForm_Load(object sender, EventArgs e)
        {
            var suppliers = _supplierService.GetAll();
            grdSuppliersListForm.DataSource = suppliers;
        }

        private void grdSuppliersListForm_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                grdSuppliersListForm.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuUpdateSupplier_Click(object sender, EventArgs e)
        {
            if(grdSuppliersListForm.SelectedRows.Count > 0)
            {
                var supplier = (Supplier)grdSuppliersListForm.SelectedRows[0].DataBoundItem; //o satıra bağlanan veri bind edilmiş
                var supplierUpdateForm = new SupplierUpdateForm(supplier.Id);
                supplierUpdateForm.MdiParent = this.MdiParent;
                supplierUpdateForm.Show();
                supplierUpdateForm.FormClosed += SupplierUpdateForm_FormClosed;
            }
        }

        private void SupplierUpdateForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            RefreshForm();
        }

        private void menuDeleteSupplier_Click(object sender, EventArgs e)
        {
            var supplier = (Supplier)grdSuppliersListForm.SelectedRows[0].DataBoundItem;
            var result = MessageBox.Show($"{supplier.CompanyName} isimli tedarikçiyi silmek istediğinizden emin misiniz ?",
                "Dikkat !",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                MessageBox.Show("Silindi");
                _supplierService.Delete(supplier);
                ((Form1)MdiParent).RefreshActiveSupplierListForm();
            }
        }

        public void RefreshForm()
        {
            var suppliers = _supplierService.GetAll();
            grdSuppliersListForm.DataSource = suppliers;
        }
    }
}
