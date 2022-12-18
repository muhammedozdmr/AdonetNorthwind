using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheNorthwind.Business;

namespace TheNorthwind.UI.Categories
{
    public partial class CategoryUpdateForm : Form
    {
        private CategoryService _categoryService = new CategoryService();
        private int _categoryId;

        //Constractorını sınırlamış oluyorum ve load anında id bilgisi dolmuş oluyor
        public CategoryUpdateForm(int categoryId)
        {
            InitializeComponent();
            _categoryId = categoryId;
        }

        private void CategoryUpdateForm_Load(object sender, EventArgs e)
        {
            var category = _categoryService.GetById(_categoryId);
            txtUpdateCategoryName.Text = category.Name;
            txtUpdateCategoryDescription.Text = category.Description;
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            var category = new Category()
            {
                Id = _categoryId,
                Name = txtUpdateCategoryName.Text,
                Description = txtUpdateCategoryDescription.Text
            };

            var result = _categoryService.Update(category);
            MessageBox.Show(result.Message);

            if (result.IsSucces)
            {
                Close();
                //TODO: CAtegoryList form refresh et
                //CategoryListForm categoryRefresh = new CategoryListForm();
                //categoryRefresh.ref
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
