namespace TheNorthwind.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.katalogYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriYönetimiToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yeniKategoriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.yeniÜrünToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.topluFiyatGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdateProductPricesBySupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdateProductPricesByCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçiYönetimiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçilerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.yeniTedarikçiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kargoYönetimiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShipperListForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuShipperCreateForm = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategoriesForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategoryCreateForm = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductListForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductCreateForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSupplierListForm = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniTedarikçiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.katalogYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(960, 35);
            this.menuStrip1.TabIndex = 0;
            // 
            // katalogYönetimiToolStripMenuItem
            // 
            this.katalogYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriYönetimiToolStripMenuItem2,
            this.ürünYönetimiToolStripMenuItem2,
            this.tedarikçiYönetimiToolStripMenuItem1,
            this.kargoYönetimiToolStripMenuItem1});
            this.katalogYönetimiToolStripMenuItem.Name = "katalogYönetimiToolStripMenuItem";
            this.katalogYönetimiToolStripMenuItem.Size = new System.Drawing.Size(161, 29);
            this.katalogYönetimiToolStripMenuItem.Text = "Katalog Yönetimi";
            // 
            // kategoriYönetimiToolStripMenuItem2
            // 
            this.kategoriYönetimiToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorilerToolStripMenuItem,
            this.toolStripSeparator1,
            this.yeniKategoriToolStripMenuItem1});
            this.kategoriYönetimiToolStripMenuItem2.Name = "kategoriYönetimiToolStripMenuItem2";
            this.kategoriYönetimiToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.kategoriYönetimiToolStripMenuItem2.Text = "Kategori Yönetimi";
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            this.kategorilerToolStripMenuItem.Click += new System.EventHandler(this.menuCategoriesForm_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // yeniKategoriToolStripMenuItem1
            // 
            this.yeniKategoriToolStripMenuItem1.Name = "yeniKategoriToolStripMenuItem1";
            this.yeniKategoriToolStripMenuItem1.Size = new System.Drawing.Size(216, 34);
            this.yeniKategoriToolStripMenuItem1.Text = "Yeni Kategori";
            this.yeniKategoriToolStripMenuItem1.Click += new System.EventHandler(this.menuCategoryCreateForm_Click);
            // 
            // ürünYönetimiToolStripMenuItem2
            // 
            this.ürünYönetimiToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem1,
            this.toolStripSeparator2,
            this.yeniÜrünToolStripMenuItem1,
            this.topluFiyatGüncellemeToolStripMenuItem});
            this.ürünYönetimiToolStripMenuItem2.Name = "ürünYönetimiToolStripMenuItem2";
            this.ürünYönetimiToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.ürünYönetimiToolStripMenuItem2.Text = "Ürün Yönetimi";
            // 
            // ürünlerToolStripMenuItem1
            // 
            this.ürünlerToolStripMenuItem1.Name = "ürünlerToolStripMenuItem1";
            this.ürünlerToolStripMenuItem1.Size = new System.Drawing.Size(295, 34);
            this.ürünlerToolStripMenuItem1.Text = "Ürünler";
            this.ürünlerToolStripMenuItem1.Click += new System.EventHandler(this.menuProductListForm_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(292, 6);
            // 
            // yeniÜrünToolStripMenuItem1
            // 
            this.yeniÜrünToolStripMenuItem1.Name = "yeniÜrünToolStripMenuItem1";
            this.yeniÜrünToolStripMenuItem1.Size = new System.Drawing.Size(295, 34);
            this.yeniÜrünToolStripMenuItem1.Text = "Yeni Ürün";
            this.yeniÜrünToolStripMenuItem1.Click += new System.EventHandler(this.menuProductCreateForm_Click);
            // 
            // topluFiyatGüncellemeToolStripMenuItem
            // 
            this.topluFiyatGüncellemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUpdateProductPricesBySupplier,
            this.menuUpdateProductPricesByCategory});
            this.topluFiyatGüncellemeToolStripMenuItem.Name = "topluFiyatGüncellemeToolStripMenuItem";
            this.topluFiyatGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.topluFiyatGüncellemeToolStripMenuItem.Text = "Toplu Fiyat Güncelleme";
            // 
            // menuUpdateProductPricesBySupplier
            // 
            this.menuUpdateProductPricesBySupplier.Name = "menuUpdateProductPricesBySupplier";
            this.menuUpdateProductPricesBySupplier.Size = new System.Drawing.Size(242, 34);
            this.menuUpdateProductPricesBySupplier.Text = "Tedarikçiye Göre";
            this.menuUpdateProductPricesBySupplier.Click += new System.EventHandler(this.menuUpdateProductPricesBySupplier_Click);
            // 
            // menuUpdateProductPricesByCategory
            // 
            this.menuUpdateProductPricesByCategory.Name = "menuUpdateProductPricesByCategory";
            this.menuUpdateProductPricesByCategory.Size = new System.Drawing.Size(242, 34);
            this.menuUpdateProductPricesByCategory.Text = "Kategoriye Göre";
            // 
            // tedarikçiYönetimiToolStripMenuItem1
            // 
            this.tedarikçiYönetimiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tedarikçilerToolStripMenuItem1,
            this.toolStripSeparator3,
            this.yeniTedarikçiToolStripMenuItem1});
            this.tedarikçiYönetimiToolStripMenuItem1.Name = "tedarikçiYönetimiToolStripMenuItem1";
            this.tedarikçiYönetimiToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.tedarikçiYönetimiToolStripMenuItem1.Text = "Tedarikçi Yönetimi";
            // 
            // tedarikçilerToolStripMenuItem1
            // 
            this.tedarikçilerToolStripMenuItem1.Name = "tedarikçilerToolStripMenuItem1";
            this.tedarikçilerToolStripMenuItem1.Size = new System.Drawing.Size(217, 34);
            this.tedarikçilerToolStripMenuItem1.Text = "Tedarikçiler";
            this.tedarikçilerToolStripMenuItem1.Click += new System.EventHandler(this.menuSupplierListForm_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(214, 6);
            // 
            // yeniTedarikçiToolStripMenuItem1
            // 
            this.yeniTedarikçiToolStripMenuItem1.Name = "yeniTedarikçiToolStripMenuItem1";
            this.yeniTedarikçiToolStripMenuItem1.Size = new System.Drawing.Size(217, 34);
            this.yeniTedarikçiToolStripMenuItem1.Text = "Yeni Tedarikçi";
            this.yeniTedarikçiToolStripMenuItem1.Click += new System.EventHandler(this.menuSupplierCreate_Click);
            // 
            // kargoYönetimiToolStripMenuItem1
            // 
            this.kargoYönetimiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuShipperListForm,
            this.toolStripSeparator4,
            this.menuShipperCreateForm});
            this.kargoYönetimiToolStripMenuItem1.Name = "kargoYönetimiToolStripMenuItem1";
            this.kargoYönetimiToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.kargoYönetimiToolStripMenuItem1.Text = "Kargo Yönetimi";
            // 
            // menuShipperListForm
            // 
            this.menuShipperListForm.Name = "menuShipperListForm";
            this.menuShipperListForm.Size = new System.Drawing.Size(270, 34);
            this.menuShipperListForm.Text = "Kargo Firmaları";
            this.menuShipperListForm.Click += new System.EventHandler(this.menuShipperListForm_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(267, 6);
            // 
            // menuShipperCreateForm
            // 
            this.menuShipperCreateForm.Name = "menuShipperCreateForm";
            this.menuShipperCreateForm.Size = new System.Drawing.Size(270, 34);
            this.menuShipperCreateForm.Text = "Yeni Kargo Firması";
            this.menuShipperCreateForm.Click += new System.EventHandler(this.menuShipperCreateForm_Click);
            // 
            // kategoriYönetimiToolStripMenuItem
            // 
            this.kategoriYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCategoriesForm,
            this.menuCategoryCreateForm});
            this.kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
            this.kategoriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.kategoriYönetimiToolStripMenuItem.Text = "Kategori Yönetimi";
            // 
            // menuCategoriesForm
            // 
            this.menuCategoriesForm.Name = "menuCategoriesForm";
            this.menuCategoriesForm.Size = new System.Drawing.Size(216, 34);
            this.menuCategoriesForm.Text = "Kategoriler";
            this.menuCategoriesForm.Click += new System.EventHandler(this.menuCategoriesForm_Click);
            // 
            // menuCategoryCreateForm
            // 
            this.menuCategoryCreateForm.Name = "menuCategoryCreateForm";
            this.menuCategoryCreateForm.Size = new System.Drawing.Size(216, 34);
            this.menuCategoryCreateForm.Text = "Yeni Kategori";
            this.menuCategoryCreateForm.Click += new System.EventHandler(this.menuCategoryCreateForm_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProductListForm,
            this.menuProductCreateForm});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menuProductListForm
            // 
            this.menuProductListForm.Name = "menuProductListForm";
            this.menuProductListForm.Size = new System.Drawing.Size(188, 34);
            this.menuProductListForm.Text = "Ürünler";
            this.menuProductListForm.Click += new System.EventHandler(this.menuProductListForm_Click);
            // 
            // menuProductCreateForm
            // 
            this.menuProductCreateForm.Name = "menuProductCreateForm";
            this.menuProductCreateForm.Size = new System.Drawing.Size(188, 34);
            this.menuProductCreateForm.Text = "Yeni Ürün";
            this.menuProductCreateForm.Click += new System.EventHandler(this.menuProductCreateForm_Click);
            // 
            // menuSupplierListForm
            // 
            this.menuSupplierListForm.Name = "menuSupplierListForm";
            this.menuSupplierListForm.Size = new System.Drawing.Size(180, 22);
            this.menuSupplierListForm.Text = "Tedarikçiler";
            this.menuSupplierListForm.Click += new System.EventHandler(this.menuSupplierListForm_Click);
            // 
            // yeniTedarikçiToolStripMenuItem
            // 
            this.yeniTedarikçiToolStripMenuItem.Name = "yeniTedarikçiToolStripMenuItem";
            this.yeniTedarikçiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniTedarikçiToolStripMenuItem.Text = "Yeni Tedarikçi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 557);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuCategoriesForm;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuProductListForm;
        private ToolStripMenuItem menuProductCreateForm;
        private ToolStripMenuItem menuCategoryCreateForm;

        private ToolStripMenuItem menuSupplierListForm;
        private ToolStripMenuItem yeniTedarikçiToolStripMenuItem;
        private ToolStripMenuItem katalogYönetimiToolStripMenuItem;
        private ToolStripMenuItem kategoriYönetimiToolStripMenuItem2;
        private ToolStripMenuItem kategorilerToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem yeniKategoriToolStripMenuItem1;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem2;
        private ToolStripMenuItem ürünlerToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem yeniÜrünToolStripMenuItem1;
        private ToolStripMenuItem tedarikçiYönetimiToolStripMenuItem1;
        private ToolStripMenuItem tedarikçilerToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem yeniTedarikçiToolStripMenuItem1;
        private ToolStripMenuItem kargoYönetimiToolStripMenuItem1;
        private ToolStripMenuItem menuShipperListForm;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem menuShipperCreateForm;
        private ToolStripMenuItem topluFiyatGüncellemeToolStripMenuItem;
        private ToolStripMenuItem menuUpdateProductPricesBySupplier;
        private ToolStripMenuItem menuUpdateProductPricesByCategory;
    }
}