namespace TheNorthwind.UI.Suppliers
{
    partial class SupplierListForm
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
            this.grdSuppliersListForm = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuUpdateSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteSupplier = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdSuppliersListForm)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdSuppliersListForm
            // 
            this.grdSuppliersListForm.AllowUserToAddRows = false;
            this.grdSuppliersListForm.AllowUserToDeleteRows = false;
            this.grdSuppliersListForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSuppliersListForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSuppliersListForm.Location = new System.Drawing.Point(0, 0);
            this.grdSuppliersListForm.Name = "grdSuppliersListForm";
            this.grdSuppliersListForm.ReadOnly = true;
            this.grdSuppliersListForm.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.grdSuppliersListForm.RowTemplate.Height = 25;
            this.grdSuppliersListForm.Size = new System.Drawing.Size(800, 450);
            this.grdSuppliersListForm.TabIndex = 0;
            this.grdSuppliersListForm.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdSuppliersListForm_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUpdateSupplier,
            this.menuDeleteSupplier});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // menuUpdateSupplier
            // 
            this.menuUpdateSupplier.Name = "menuUpdateSupplier";
            this.menuUpdateSupplier.Size = new System.Drawing.Size(180, 22);
            this.menuUpdateSupplier.Text = "Düzenle";
            this.menuUpdateSupplier.Click += new System.EventHandler(this.menuUpdateSupplier_Click);
            // 
            // menuDeleteSupplier
            // 
            this.menuDeleteSupplier.Name = "menuDeleteSupplier";
            this.menuDeleteSupplier.Size = new System.Drawing.Size(180, 22);
            this.menuDeleteSupplier.Text = "Sil";
            this.menuDeleteSupplier.Click += new System.EventHandler(this.menuDeleteSupplier_Click);
            // 
            // SupplierListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdSuppliersListForm);
            this.Name = "SupplierListForm";
            this.Text = "SupplierListForm";
            this.Load += new System.EventHandler(this.SupplierListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSuppliersListForm)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdSuppliersListForm;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuUpdateSupplier;
        private ToolStripMenuItem menuDeleteSupplier;
    }
}