using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace TheNorthwind.DataAccess
{
    public class ShipperRepository
    {
        public void Add(Shipper shipper)
        {
            using (var connection = new SqlConnection(DbSettings.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"insert into Shippers (CompanyName,Phone) values (@companyName,@phone)";
                command.Parameters.AddWithValue("@companyName", shipper.Name);
                command.Parameters.AddWithValue("@phone", shipper.Phone);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Update(Shipper shipper)
        {
            using (var connection = new SqlConnection(DbSettings.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"update Shippers set CompanyName=@companyName,Phone=@phone where ShipperID = @id";

                command.Parameters.AddWithValue("@id", shipper.Id);
                command.Parameters.AddWithValue("@companyName", shipper.Name);
                command.Parameters.AddWithValue("phone", shipper.Phone);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(DbSettings.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "delete from Shippers where ShipperID = @id";
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(Shipper shipper)
        {
            Delete(shipper.Id);
        }
        private Shipper MapShipper(SqlDataReader reader)
        {
            return new Shipper()
            {
                Id = reader.GetInt32("ShipperID"),
                Name = reader.GetStringNullable("CompanyName"),
                Phone = reader.GetStringNullable("Phone")
            };
        }

        public List<Shipper> GetAll()
        {
            var shippers = new List<Shipper>();
            using (var connection = new SqlConnection(DbSettings.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Shippers";
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        shippers.Add(MapShipper(reader));
                    }
                }
                connection.Close();
            }
            return shippers;
        }

        public Shipper GetById(int id)
        {
            Shipper shipper = null;
            using (var connection = new SqlConnection(DbSettings.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Shippers where ShipperID = @id";
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        shipper = new Shipper()
                        {
                            Id = reader.GetInt32("ShipperID"),
                            Name = reader.GetStringNullable("CompanyName"),
                            Phone = reader.GetStringNullable("Phone")
                        };
                    }
                    connection.Close();
                }
            }
            return shipper;
        }
    }
}
