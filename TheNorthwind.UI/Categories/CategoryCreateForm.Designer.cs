namespace TheNorthwind.UI.Categories
{
    partial class CategoryCreateForm
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
            this.btnCategorySave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreateCategoryName = new System.Windows.Forms.TextBox();
            this.txtCreateCategoryDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCategorySave
            // 
            this.btnCategorySave.Location = new System.Drawing.Point(245, 118);
            this.btnCategorySave.Name = "btnCategorySave";
            this.btnCategorySave.Size = new System.Drawing.Size(75, 23);
            this.btnCategorySave.TabIndex = 0;
            this.btnCategorySave.Text = "Kaydet";
            this.btnCategorySave.UseVisualStyleBackColor = true;
            this.btnCategorySave.Click += new System.EventHandler(this.btnCategorySave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Açıklama:";
            // 
            // txtCreateCategoryName
            // 
            this.txtCreateCategoryName.Location = new System.Drawing.Point(132, 32);
            this.txtCreateCategoryName.Name = "txtCreateCategoryName";
            this.txtCreateCategoryName.Size = new System.Drawing.Size(188, 23);
            this.txtCreateCategoryName.TabIndex = 3;
            // 
            // txtCreateCategoryDescription
            // 
            this.txtCreateCategoryDescription.Location = new System.Drawing.Point(132, 60);
            this.txtCreateCategoryDescription.Multiline = true;
            this.txtCreateCategoryDescription.Name = "txtCreateCategoryDescription";
            this.txtCreateCategoryDescription.Size = new System.Drawing.Size(188, 52);
            this.txtCreateCategoryDescription.TabIndex = 3;
            // 
            // CategoryCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 293);
            this.Controls.Add(this.txtCreateCategoryDescription);
            this.Controls.Add(this.txtCreateCategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCategorySave);
            this.Name = "CategoryCreateForm";
            this.Text = "Kayıt Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCategorySave;
        private Label label1;
        private Label label2;
        private TextBox txtCreateCategoryName;
        private TextBox txtCreateCategoryDescription;
    }
}