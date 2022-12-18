namespace TheNorthwind.UI.Employee
{
    partial class EmployeeListForm
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
            this.grdEmployee = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuUpdateEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteEmployee = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdEmployee
            // 
            this.grdEmployee.AllowUserToAddRows = false;
            this.grdEmployee.AllowUserToDeleteRows = false;
            this.grdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEmployee.Location = new System.Drawing.Point(0, 0);
            this.grdEmployee.MultiSelect = false;
            this.grdEmployee.Name = "grdEmployee";
            this.grdEmployee.ReadOnly = true;
            this.grdEmployee.RowHeadersWidth = 62;
            this.grdEmployee.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.grdEmployee.RowTemplate.Height = 33;
            this.grdEmployee.Size = new System.Drawing.Size(800, 450);
            this.grdEmployee.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUpdateEmployee,
            this.menuDeleteEmployee});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 68);
            // 
            // menuUpdateEmployee
            // 
            this.menuUpdateEmployee.Name = "menuUpdateEmployee";
            this.menuUpdateEmployee.Size = new System.Drawing.Size(147, 32);
            this.menuUpdateEmployee.Text = "Düzenle";
            // 
            // menuDeleteEmployee
            // 
            this.menuDeleteEmployee.Name = "menuDeleteEmployee";
            this.menuDeleteEmployee.Size = new System.Drawing.Size(147, 32);
            this.menuDeleteEmployee.Text = "Sil";
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdEmployee);
            this.Name = "EmployeeListForm";
            this.Text = "Çalışan Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdEmployee;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuUpdateEmployee;
        private ToolStripMenuItem menuDeleteEmployee;
    }
}