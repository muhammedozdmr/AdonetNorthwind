namespace TheNorthwind.UI.Shippers
{
    partial class ShipperListForm
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
            this.grdShippersListForm = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuUpdateShipper = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteShipper = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdShippersListForm)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdShippersListForm
            // 
            this.grdShippersListForm.AllowUserToAddRows = false;
            this.grdShippersListForm.AllowUserToDeleteRows = false;
            this.grdShippersListForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdShippersListForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdShippersListForm.Location = new System.Drawing.Point(0, 0);
            this.grdShippersListForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdShippersListForm.MultiSelect = false;
            this.grdShippersListForm.Name = "grdShippersListForm";
            this.grdShippersListForm.ReadOnly = true;
            this.grdShippersListForm.RowHeadersWidth = 62;
            this.grdShippersListForm.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.grdShippersListForm.RowTemplate.Height = 25;
            this.grdShippersListForm.Size = new System.Drawing.Size(969, 750);
            this.grdShippersListForm.TabIndex = 0;
            this.grdShippersListForm.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdShippersListForm_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUpdateShipper,
            this.menuDeleteShipper});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 68);
            // 
            // menuUpdateShipper
            // 
            this.menuUpdateShipper.Name = "menuUpdateShipper";
            this.menuUpdateShipper.Size = new System.Drawing.Size(147, 32);
            this.menuUpdateShipper.Text = "Düzenle";
            this.menuUpdateShipper.Click += new System.EventHandler(this.menuUpdateShipper_Click);
            // 
            // menuDeleteShipper
            // 
            this.menuDeleteShipper.Name = "menuDeleteShipper";
            this.menuDeleteShipper.Size = new System.Drawing.Size(147, 32);
            this.menuDeleteShipper.Text = "Sil";
            this.menuDeleteShipper.Click += new System.EventHandler(this.menuDeleteShipper_Click);
            // 
            // ShipperListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 750);
            this.Controls.Add(this.grdShippersListForm);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShipperListForm";
            this.Text = "ShipperListForm";
            this.Load += new System.EventHandler(this.ShipperListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdShippersListForm)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdShippersListForm;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuUpdateShipper;
        private ToolStripMenuItem menuDeleteShipper;
    }
}