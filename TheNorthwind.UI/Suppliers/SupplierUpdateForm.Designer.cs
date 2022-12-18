namespace TheNorthwind.UI.Suppliers
{
    partial class SupplierUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // txtHomePage
            // 
            this.txtHomePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // btnSave
            // 
            this.btnSave.Text = "Güncelle";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // txtFax
            // 
            this.txtFax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // txtPhone
            // 
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // txtCountryName
            // 
            this.txtCountryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // txtRegion
            // 
            this.txtRegion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // txtCity
            // 
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // txtAddress
            // 
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // txtContactName
            // 
            this.txtContactName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // SupplierUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 668);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "SupplierUpdateForm";
            this.Text = "Tedarikçi Güncelleme Ekranı";
            this.Load += new System.EventHandler(this.SupplierUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}