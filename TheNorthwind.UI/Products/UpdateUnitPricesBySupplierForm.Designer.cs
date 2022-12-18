namespace TheNorthwind.UI.Products
{
    partial class UpdateUnitPricesBySupplierForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.numPriceChangeRate = new System.Windows.Forms.NumericUpDown();
            this.rbtDiscount = new System.Windows.Forms.RadioButton();
            this.rbtRaise = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceChangeRate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tedarikçi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat Değişim Oranı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat Değişim Tipi:";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(191, 25);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(176, 23);
            this.cmbSupplier.TabIndex = 3;
            // 
            // numPriceChangeRate
            // 
            this.numPriceChangeRate.DecimalPlaces = 2;
            this.numPriceChangeRate.Location = new System.Drawing.Point(191, 63);
            this.numPriceChangeRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPriceChangeRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numPriceChangeRate.Name = "numPriceChangeRate";
            this.numPriceChangeRate.Size = new System.Drawing.Size(176, 23);
            this.numPriceChangeRate.TabIndex = 4;
            this.numPriceChangeRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // rbtDiscount
            // 
            this.rbtDiscount.AutoSize = true;
            this.rbtDiscount.Checked = true;
            this.rbtDiscount.Location = new System.Drawing.Point(191, 100);
            this.rbtDiscount.Name = "rbtDiscount";
            this.rbtDiscount.Size = new System.Drawing.Size(63, 19);
            this.rbtDiscount.TabIndex = 5;
            this.rbtDiscount.TabStop = true;
            this.rbtDiscount.Text = "İndirim";
            this.rbtDiscount.UseVisualStyleBackColor = true;
            // 
            // rbtRaise
            // 
            this.rbtRaise.AutoSize = true;
            this.rbtRaise.Location = new System.Drawing.Point(281, 100);
            this.rbtRaise.Name = "rbtRaise";
            this.rbtRaise.Size = new System.Drawing.Size(49, 19);
            this.rbtRaise.TabIndex = 6;
            this.rbtRaise.Text = "Zam";
            this.rbtRaise.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(292, 145);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Uygula";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // UpdateUnitPricesBySupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 243);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.rbtRaise);
            this.Controls.Add(this.rbtDiscount);
            this.Controls.Add(this.numPriceChangeRate);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateUnitPricesBySupplierForm";
            this.Text = "Tedarikçiye Göre Ürün Fiyat Güncellemesi";
            this.Load += new System.EventHandler(this.UpdateUnitPricesBySupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPriceChangeRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbSupplier;
        private NumericUpDown numPriceChangeRate;
        private RadioButton rbtDiscount;
        private RadioButton rbtRaise;
        private Button btnApply;
    }
}