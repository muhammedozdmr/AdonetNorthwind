namespace TheNorthwind.UI.Shippers
{
    partial class ShipperCreateForm
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(284, 57);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtName.Size = new System.Drawing.Size(254, 31);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(284, 110);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtPhone.Size = new System.Drawing.Size(254, 31);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(438, 157);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSave.Size = new System.Drawing.Size(100, 34);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ShipperCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 312);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "ShipperCreateForm";
            this.Text = "Kargo Firması Kayıt Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}