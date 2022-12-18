using TheNorthwind.DataAccess;

namespace TheNorthwind.Business
{
    public class ShipperService
    {
        private ShipperRepository _repository = new ShipperRepository();
        public List<Shipper> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception ex)
            {
                CommandResult.Failure("Hatalı İşlem !", ex);
                return new List<Shipper>();
            }
        }
        public Shipper GetById(int id)
        {
            try
            {
                return _repository.GetById(id);
            }
            catch (Exception ex)
            {
                //TODO: Hata mesajın loglanacak
                throw;
            }
        }
        public CommandResult Create(Shipper shipper)
        {
            try
            {
                _repository.Add(shipper);
                return CommandResult.Success("Ekleme Başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failure("İşlem Başarısız !", ex);
            }
        }
        public CommandResult Update(Shipper shipper)
        {
            try
            {
                _repository.Update(shipper);
                return CommandResult.Success("Güncelleme Başarılı");
            }
            catch (Exception ex)
            {
                return CommandResult.Failure("Güüncelleme hatası !", ex);
            }
        }
        public CommandResult Delete(Shipper shipper)
        {
            try
            {
                _repository.Delete(shipper);
                return CommandResult.Success("Silme işlemi başarılı !");

            }
            catch (Exception ex)
            {
                return CommandResult.Failure("Silme işlemi hatası",ex);
            }
        }

    }
}
