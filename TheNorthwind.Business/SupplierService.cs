using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNorthwind.DataAccess;

namespace TheNorthwind.Business
{
    public class SupplierService
    {
        private SupplierRepository _repository = new SupplierRepository();
        public List<Supplier> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception ex)
            {
                CommandResult.Failure("Hatalı İşlem", ex);
                return new List<Supplier>();
            }
        }

        public Supplier GetById(int id)
        {
            try
            {
                return _repository.Find(id);
            }
            catch (Exception ex)
            {
                //TODO: Hata mesajı loglanacak
                throw;
            }
        }

        public CommandResult Create(Supplier supplier)
        {
            try
            {
                //factory patternsiz yapıldı
                _repository.Add(supplier);
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

        public CommandResult Update(Supplier supplier)
        {
            //factorypattern ile yapıldı
            try
            {
                _repository.Update(supplier);
                return CommandResult.Success("Güncellem Başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failure("Güncelleme Hatalı !", ex);
            }
        }

        public CommandResult Delete(Supplier supplier)
        {
            try
            {
                _repository.Remove(supplier);
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
    }
}
