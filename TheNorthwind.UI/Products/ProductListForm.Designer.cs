namespace TheNorthwind.UI.Products
{
    partial class ProductListForm
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
            this.components = new System.ComponentModel.Container();
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuUpdateProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteProduct = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdProduct
            // 
            this.grdProduct.AllowUserToAddRows = false;
            this.grdProduct.AllowUserToDeleteRows = false;
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProduct.Location = new System.Drawing.Point(0, 0);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.ReadOnly = true;
            this.grdProduct.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.grdProduct.RowTemplate.Height = 25;
            this.grdProduct.Size = new System.Drawing.Size(800, 450);
            this.grdProduct.TabIndex = 0;
            this.grdProduct.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdProduct_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUpdateProduct,
            this.menuDeleteProduct});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // menuUpdateProduct
            // 
            this.menuUpdateProduct.Name = "menuUpdateProduct";
            this.menuUpdateProduct.Size = new System.Drawing.Size(116, 22);
            this.menuUpdateProduct.Text = "Düzenle";
            this.menuUpdateProduct.Click += new System.EventHandler(this.menuUpdateProduct_Click);
            // 
            // menuDeleteProduct
            // 
            this.menuDeleteProduct.Name = "menuDeleteProduct";
            this.menuDeleteProduct.Size = new System.Drawing.Size(116, 22);
            this.menuDeleteProduct.Text = "Sil";
            this.menuDeleteProduct.Click += new System.EventHandler(this.menuDeleteProduct_Click);
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdProduct);
            this.Name = "ProductListForm";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.ProductListForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdProduct;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuUpdateProduct;
        private ToolStripMenuItem menuDeleteProduct;
    }
}