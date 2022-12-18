namespace TheNorthwind.UI.Products
{
    partial class UpdateUnitPricesConfirmationBox
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
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProduct
            // 
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.Location = new System.Drawing.Point(24, 14);
            this.grdProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.RowHeadersWidth = 62;
            this.grdProduct.RowTemplate.Height = 25;
            this.grdProduct.Size = new System.Drawing.Size(524, 263);
            this.grdProduct.TabIndex = 0;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(307, 351);
            this.btnYes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(107, 38);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Evet";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(442, 351);
            this.btnNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(107, 38);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "Hayır";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 297);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bu ürünlerin fiyatı güncellenecektir,  devam etmek istiyor musunuz ?";
            // 
            // UpdateUnitPricesConfirmationBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.grdProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateUnitPricesConfirmationBox";
            this.Text = "UpdateUnitPricesConfirmationBox";
            this.Load += new System.EventHandler(this.UpdateUnitPricesConfirmationBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdProduct;
        private Button btnYes;
        private Button btnNo;
        private Label label1;
    }
}