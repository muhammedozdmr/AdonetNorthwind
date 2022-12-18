using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNorthwind.DataAccess;

namespace TheNorthwind.Business
{
    //CategoryBusiness
    //CategoryBLL(Business Layer Logic)
    //CategoryManager
    //CategoryFacade
    public class CategoryService
    {
        private CategoryRepository _repository = new CategoryRepository();
        public List<Category> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception ex)
            {
                //TODO: Hata mesajı logla
                return new List<Category>();
            }
        }

        public Category GetById(int id)
        {
            try
            {
                return _repository.GetById(id);
            }
            catch (Exception ex)
            {
                //TODO: Hata mesajı loglanacak
                throw;
            }
        }

        public CommandResult Create(Category category)
        {
            try
            {
                //factory patternsiz yapıldı
                _repository.Add(category);
                return new CommandResult() 
                {
                    IsSucces = true,
                    Message = "Ekleme Başarılı"
                };
            }
            catch (Exception ex)
            {
                //TODO: Hata mesajı logla
                //TODO: Hata bilgisini return et
                return new CommandResult()
                {
                    IsSucces = true,
                    Message = "Hatalı Ekleme !",
                    ErrorMessage = ex.ToString()
                };
            }
        }

        public CommandResult Update(Category category)
        {
            //factorypattern ile yapıldı
            try
            {
                _repository.Update(category);
                return CommandResult.Success("Güncelleme Başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failure("Güncelleme Hatalı !", ex);
            }
        }

        public CommandResult Delete(Category category)
        {
            try
            {
                _repository.Remove(category);
                return new CommandResult()
                {
                    IsSucces = true,
                    Message = "Silme İşlemi Başarılı"
                };
            }
            catch (Exception ex)
            {
                return new CommandResult()
                {
                    IsSucces = false,
                    Message = "Silme İşlemi Hatalı !",
                    ErrorMessage = ex.ToString()
                };
            }
        }

        //TODO: Category Repository ve Category Service yap
    }
}