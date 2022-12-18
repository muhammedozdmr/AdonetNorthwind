namespace TheNorthwind.UI.Shippers
{
    partial class ShipperUpdateFom
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
            // btnSave
            // 
            this.btnSave.Text = "Güncelle";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ShipperUpdateFom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 348);
            this.Name = "ShipperUpdateFom";
            this.Text = "Kargo Firması Güncelleme Ekranı";
            this.Load += new System.EventHandler(this.ShipperUpdateFom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}