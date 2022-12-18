using TheNorthwind.UI.Categories;
using TheNorthwind.UI.Products;
using TheNorthwind.UI.Shippers;
using TheNorthwind.UI.Suppliers;

namespace TheNorthwind.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuCategoriesForm_Click(object sender, EventArgs e)
        {
            var categoryListForm = new CategoryListForm();
            categoryListForm.MdiParent = this; //set edildi MDI parent ve child mantýðýna bak mantýk form1 içinde categories çýkýyor
            categoryListForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void menuProductListForm_Click(object sender, EventArgs e)
        {
            var productListForm = new ProductListForm();
            productListForm.MdiParent = this;
            productListForm.Show();
        }

        private void menuProductCreateForm_Click(object sender, EventArgs e)
        {
            var productCreateForm = new ProductCreateForm();
            productCreateForm.MdiParent = this;
            productCreateForm.Show();
        }

        private void menuCategoryCreateForm_Click(object sender, EventArgs e)
        {
            var categoryCreateForm = new CategoryCreateForm();
            categoryCreateForm.MdiParent = this;
            categoryCreateForm.Show();
        }

        private void menuSupplierListForm_Click(object sender, EventArgs e)
        {
            var supplierListForm = new SupplierListForm();
            supplierListForm.MdiParent = this;
            supplierListForm.Show();
        }

        private void menuSupplierCreate_Click(object sender, EventArgs e)
        {
            var supplierCreateForm = new SupplierCreateForm();
            supplierCreateForm.MdiParent = this;
            supplierCreateForm.Show();
        }
        private void menuShipperListForm_Click(object sender, EventArgs e)
        {
            var shipperListForm = new ShipperListForm();
            shipperListForm.MdiParent = this;
            shipperListForm.Show();
        }
        private void menuShipperCreateForm_Click(object sender, EventArgs e)
        {
            var shipperCreateForm = new ShipperCreateForm();
            shipperCreateForm.MdiParent = this;
            shipperCreateForm.Show();
        }

        public void RefreshActiveCategoryListForm()
        {
            foreach (var mdiChild in MdiChildren)
            {
                if (mdiChild is CategoryListForm)
                {
                    ((CategoryListForm)mdiChild).RefreshForm();
                }
            }
        }
        public void RefreshActiveSupplierListForm()
        {
            foreach (var mdiChild in MdiChildren)
            {
                if (mdiChild is SupplierListForm)
                {
                    ((SupplierListForm)mdiChild).RefreshForm();
                }
            }
        }
        public void RefreshActiveShippersListForm()
        {
            foreach(var mdiChild in MdiChildren)
            {
                if(mdiChild is ShipperListForm)
                {
                    ((ShipperListForm)mdiChild).RefreshForm();
                }
            }
        }

        private void menuUpdateProductPricesBySupplier_Click(object sender, EventArgs e)
        {
            var productPricesForm = new UpdateUnitPricesBySupplierForm();
            productPricesForm.MdiParent = this;
            productPricesForm.Show();
        }


    }
}