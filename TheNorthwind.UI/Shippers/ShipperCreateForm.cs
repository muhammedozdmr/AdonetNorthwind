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
    public partial class ShipperCreateForm : ShipperEditForm
    {
        private ShipperService _shipperService = new ShipperService();
        public ShipperCreateForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var shipper = new Shipper()
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
            };
            var result = _shipperService.Create(shipper);
            ProcessCommandResult(result);
            
        }

        private void ProcessCommandResult(CommandResult result)
        {
            if (result.IsSucces)
            {
                foreach(var mdiChild in MdiParent.MdiChildren)
                {
                    if(mdiChild is ShipperListForm)
                    {
                        var shipperListForm = (ShipperListForm)mdiChild;
                        shipperListForm.RefreshForm();
                    }
                }
                var dialogResult = MessageBox.Show("Yeni bir kayıt eklemek istiyor musunuz ?", result.Message, MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Information);
                if(dialogResult == DialogResult.Yes)
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
                    "Hata mesajını görüntülemek ister misiniz ?",result.Message,MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
        }

    }
}

