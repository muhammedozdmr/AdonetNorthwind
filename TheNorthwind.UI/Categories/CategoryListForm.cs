using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheNorthwind.Business;

namespace TheNorthwind.UI.Categories
{
    public partial class CategoryListForm : Form
    {
        //Sürekli kullanabileceğim için en başta field olarak yaptım
        private CategoryService _categoryService = new CategoryService();
        public CategoryListForm()
        {
            InitializeComponent();
        }

        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            //var categoryService = new CategoryService();
            //var categories = categoryService.GetAll();
            var categories = _categoryService.GetAll();
            grdCategories.DataSource = categories;
            //data bind denir bu datasource işlemine veri bağlama geçmiş hali bound
        }

        private void grdCategories_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //RowIndex kolon isimlerinde -1 sayar 0. satır datanın ilk satırı
            if (e.RowIndex >= 0) //eventten gelen satır indexi demek
            {
                grdCategories.Rows[e.RowIndex].Selected = true; //mouse down olduğu anda satırı seçili hale getirir
                                                                //if(e.Button == MouseButtons.Right)
                                                                //{
                                                                //Sağ tuşa basma durumu kontrolü zaten contextmenude bu otomatik oluyor 
                                                                //}
            }
        }

        private void menuUpdateCategory_Click(object sender, EventArgs e)
        {
            if (grdCategories.SelectedRows.Count > 0) //gridde en az 1 satır seçili ise
            {
                var category = (Category)grdCategories.SelectedRows[0].DataBoundItem; //selectedRows ilk başta
                                                                                      //contextmenu properties i multi selectedı false ettik
                                                                                      //Test amaçlı yazıldı Id değeri kontrolü için
                                                                                      //MessageBox.Show(category.Id.ToString());

                var categoryUpdateForm = new CategoryUpdateForm(category.Id);
                categoryUpdateForm.MdiParent = this.MdiParent;
                categoryUpdateForm.Show(); //show metodu load eventini tetikler
                categoryUpdateForm.FormClosed += CategoryUpdateForm_FormClosed;
            }
        }

        private void CategoryUpdateForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            RefreshForm();
        }

        private void menuDeleteCategory_Click(object sender, EventArgs e)
        {
            if (grdCategories.SelectedRows.Count > 0) //gridde en az 1 satır seçili ise
            {
                var category = (Category)grdCategories.SelectedRows[0].DataBoundItem;
                var result = MessageBox.Show($"{category.Name} isimli kategoriyi silmek istediğinize emin misiniz ?",
                    "Dikkat!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //TODO: servisten Delete metodu çağır !!
                    MessageBox.Show("Silindi !");
                    _categoryService.Delete(category);
                    ((Form1)MdiParent).RefreshActiveCategoryListForm();
                }

                //Bu sadece açık olan son ekranı refresh eder
                //_categoryService.Delete(category);
                //RefreshForm();
                //grdCategories.DataSource = deleteCategory;
            }
        }

        public void RefreshForm()
        {
            var categories = _categoryService.GetAll();
            grdCategories.DataSource = categories;
        }
    }
}

//TODO: Hocanın yaptığı projede BaseForm kısmını incele