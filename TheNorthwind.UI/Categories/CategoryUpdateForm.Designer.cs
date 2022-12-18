namespace TheNorthwind.UI.Categories
{
    partial class CategoryUpdateForm
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
            this.txtUpdateCategoryName = new System.Windows.Forms.TextBox();
            this.txtUpdateCategoryDescription = new System.Windows.Forms.TextBox();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açıklama:";
            // 
            // txtUpdateCategoryName
            // 
            this.txtUpdateCategoryName.Location = new System.Drawing.Point(118, 21);
            this.txtUpdateCategoryName.Name = "txtUpdateCategoryName";
            this.txtUpdateCategoryName.Size = new System.Drawing.Size(183, 23);
            this.txtUpdateCategoryName.TabIndex = 1;
            // 
            // txtUpdateCategoryDescription
            // 
            this.txtUpdateCategoryDescription.Location = new System.Drawing.Point(118, 60);
            this.txtUpdateCategoryDescription.Multiline = true;
            this.txtUpdateCategoryDescription.Name = "txtUpdateCategoryDescription";
            this.txtUpdateCategoryDescription.Size = new System.Drawing.Size(183, 49);
            this.txtUpdateCategoryDescription.TabIndex = 1;
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(226, 115);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryUpdate.TabIndex = 2;
            this.btnCategoryUpdate.Text = "Güncelle";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // CategoryUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 282);
            this.Controls.Add(this.btnCategoryUpdate);
            this.Controls.Add(this.txtUpdateCategoryDescription);
            this.Controls.Add(this.txtUpdateCategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CategoryUpdateForm";
            this.Text = "Güncelleme Ekranı";
            this.Load += new System.EventHandler(this.CategoryUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUpdateCategoryName;
        private TextBox txtUpdateCategoryDescription;
        private Button btnCategoryUpdate;
    }
}