using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNorthwind.DataAccess;

namespace TheNorthwind.Business
{
    public class ProductService
    {
        private ProductRepository _repository = new ProductRepository();
        public List<Product> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception ex)
            {
                CommandResult.Failure("Hata Tespit Edildi", ex);
                return new List<Product>();
            }
        }
        public Product Find(int id)
        {
            try
            {
                return _repository.GetById(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public CommandResult Create(Product product)
        {
            try
            {
                _repository.Add(product);
                return CommandResult.Success("Ekleme Başarılı !");
            }
            catch (Exception ex)
            {
                return CommandResult.Failure("Ekleme Başarısız !", ex);
            }
        }
        public CommandResult Update(Product product)
        {
            try
            {
                _repository.Update(product);
                return CommandResult.Success("Güncelleme Başarılı !");
            }
            catch (Exception ex)
            {
                return CommandResult.Failure("Güncelleme Başarısız !", ex);
            }
        }
        public CommandResult Remove(Product product)
        {
            try
            {
                _repository.Remove(product);
                return CommandResult.Success("Silme İşlemi Başarılı !");
            }
            catch (Exception ex)
            {
                return CommandResult.Failure("Silme İşlemi Başarısız !", ex);
            }

        }
        public CommandResult UpdatePricesBySupplier(int supplierId,decimal changeRate,bool isDiscount)
        {
            try
            {
                //ideal birkontrol değil ama repository de yeni bir method yazmadan dayapılabilir görmek için
                var allProducts = _repository.GetAll();
                var productsToUpdate = new List<Product>();
                foreach(var product in allProducts)
                {
                    if(product.SupplierId == supplierId)
                    {
                        productsToUpdate.Add(product);
                    }
                }

                changeRate = isDiscount ? -changeRate : changeRate;

                for(int i = 0; i < productsToUpdate.Count; i++)
                {
                    //0.1
                    //indirim
                    //-0.1

                    //1 + (-0.1) => 0.9
                    //UnitPrice <= 100 * 0.9
                    //UnitPrice -> 90
                    productsToUpdate[i].UnitPrice += 1 + changeRate;

                    //UnitOfWork
                    //Aşağıdaki işlem biraz hantal bir ilerleyiş update metodu her çağrıldığında yeni baştan SqlConnection,SqlCommand
                    //nesneleri olujşturup, işlem sonunda yıkılıyor
                    //Bu toplu güncelleme işlemini tek bir Transaction (bkz, inceleyiniz)
                    //altında yapabilmek için UnitOfWork patter'ınına ihtiyacımız var
                    _repository.Update(productsToUpdate[i]);
                }
                return CommandResult.Success("Başarılı");
            }

            catch (Exception ex)
            {
                return CommandResult.Failure("Hata Aldın !",ex);
            }
        }
        public List<Product>GetBySupplierId(int supplierId)
        {
            try
            {
                var allProducts = _repository.GetAll();
                var productBySupplierId = new List<Product>();
                foreach (var product in allProducts)
                {
                    if (product.SupplierId == supplierId)
                    {
                        productBySupplierId.Add(product);
                    }
                }
                return productBySupplierId;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
