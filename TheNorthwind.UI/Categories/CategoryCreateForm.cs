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
    public partial class CategoryCreateForm : Form
    {
        private CategoryService _categortService = new CategoryService();
        public CategoryCreateForm()
        {
            InitializeComponent();
        }

        private void btnCategorySave_Click(object sender, EventArgs e)
        {

            var category = new Category()
            {
                Name = txtCreateCategoryName.Text,
                Description = txtCreateCategoryDescription.Text,
            };

            var result = _categortService.Create(category);

            //CommandResult nesnesini UI katmanında nasıl kullanabilirim ?
            //Yöntem 1
            //Başarılı da olsa başarısız da olsa mesajı doğrudan yazdırabilirsin
            MessageBox.Show(result.Message);

            //---------------------------------------------//
            //Ya da
            //Yöntem 2
            if (result.IsSucces)
            {
                //Ekleme anında bütün açık pencerelerdeki datayı güncelliyor
                //MdiParent'ından childeren'ına ulaştık
                foreach (var mdiChild in MdiParent.MdiChildren)
                {
                    if (mdiChild is CategoryListForm)
                    {
                        var categoryListForm = (CategoryListForm)mdiChild;
                        categoryListForm.RefreshForm();
                    }
                }
                //Kaydetme başarılı olursa formu kapat
                Close();

            }
            else
            {
                //Hata durumunda mesajı yazdır
                MessageBox.Show(result.Message);
            }
        }
    }
}
