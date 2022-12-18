using System.Data;
using System.Data.SqlClient;

namespace TheNorthwind.DataAccess
{
    //Repository Pattern
    //Repository => Depo anlamına gelir
    //Projelerin veriye erişen katmanlarında, Sql'de bir tabloyu temsilen koleksiyon tipindeki nesnelerin
    //ve bir satırlık kayıdı temsilen Entity nesnelerinin oluşturulduğu, çözümlendiği katman

    //Kategori tablosu ile ilgili veri işlemleri bu sınıfa yer alacak
    //Veri İşlemleri? CRUD
    //Create
    //Read
    //Update{

    //Delete
    public class CategoryRepository
    {
        //Create, Insert
        public void Add(Category category)
        {
            using (var sqlConnection = new SqlConnection(DbSettings.ConnectionString))
            using (var sqlCommand = sqlConnection.CreateCommand())
            {
                sqlCommand.CommandText = "insert into Categories(CategoryName, Description) values (@name, @description)";
                sqlCommand.Parameters.AddWithValue("@name", category.Name);
                sqlCommand.Parameters.AddWithValue("@description", category.Description);
                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }
        public void Update(Category category)
        {
            using (var sqlConnection = new SqlConnection(DbSettings.ConnectionString))
            using (var sqlCommand = sqlConnection.CreateCommand())
            {
                sqlCommand.CommandText = "update Categories set CategoryName = @name, Description = @description where CategoryID = @id";

                sqlCommand.Parameters.AddWithValue("@id", category.Id);
                sqlCommand.Parameters.AddWithValue("@name", category.Name);
                sqlCommand.Parameters.AddWithValue("@description", category.Description);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        //Delete
        public void Remove(Category category)
        {
            Remove(category.Id);
        }
        public void Remove(int id)
        {
            using(var sqlConnection = new SqlConnection(DbSettings.ConnectionString))
            using (var sqlCommand = sqlConnection.CreateCommand())
            {
                sqlCommand.CommandText = "delete from Categories where CategoryID = @id";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }

            //Remove(new Category() { Id = id }); //Böylede yukarıdakini çağırmış oluruz
        }
        public Category GetById(int id)
        {
            var category = default(Category); //boş gelebilir o yüzden en başta default olarak oluşturup
            //ekrana eğer boşsa null değer döndürürüm

            using (var sqlConnection = new SqlConnection(DbSettings.ConnectionString))
            using (var sqlCommand = sqlConnection.CreateCommand())
            {
                //sqlCommand.Connection = sqlConnection; CreateCommand ile otomatik yapıyor
                sqlCommand.CommandText = "select * from Categories where CategoryID = @id";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlConnection.Open();
                using (var dataReader = sqlCommand.ExecuteReader())
                {
                    if (dataReader.HasRows && dataReader.Read()) //Satır varsa ve okunabiliyorsa zaten sorgu ile 1 tane satır getiricem
                                                                 //while a ihtiyaç yok o yüzden
                    {
                        category = new Category()
                        {
                            //normalde GetInt32 index bazlı alır ama biz string yazıyoruz
                            //çünkü extension metodu var System.Data üzerine yazılmıştır.
                            //ctrl + . ile System Data eklenir
                            Id = dataReader.GetInt32("CategoryID"),
                            Name = dataReader.GetString("CategoryName"),
                            Description = dataReader.GetString("Description")
                        };
                    }
                }
                sqlConnection.Close();
            }
            return category;
        }
        public List<Category> GetAll()
        {
            using (var sqlConnection = new SqlConnection(DbSettings.ConnectionString))
            using (var sqlCommand = new SqlCommand())
            {
                try
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "select CategoryID, CategoryName, Description from Categories";

                    sqlConnection.Open();
                    var categoryList = new List<Category>();
                    //her zaman datareader dispose edilmedi bu yüzden kendim manuel yazmak yerine using ile otomatik yapıyorum
                    using (var dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            var category = new Category()
                            {
                                //dataReader, Result Set içindeki kolon isimleri ile ilgileniri onları bilir
                                //Eğer sorguda kolon isimleri alia ile değiştirildiyse
                                //dataReader["KOLON_ADI"] kısmında yazlacak kolon adı da alias ile aynı olmalıdır

                                Id = (int)dataReader["CategoryID"], //dataReaderdan her hücre obect olarak geliyor cast edip set ediyorum
                                Name = (string)dataReader["CategoryName"],
                                Description = (string)dataReader["Description"],
                            };
                            categoryList.Add(category);
                        }
                    }
                    sqlConnection.Close();

                    return categoryList;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

    }
}

//TODO: Hocanın yazdığı kodda region kısmını incele