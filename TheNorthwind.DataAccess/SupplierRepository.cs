using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

//Ctrl + R + G kullanılmayan using namespaceleri uçuruyor

namespace TheNorthwind.DataAccess
{
    public class SupplierRepository
    {
        public Supplier Find(int id)
        {
            //var supplier = default(Supplier);
            Supplier supplier = null;

            using (var sqlConnection = new SqlConnection(DbSettings.ConnectionString))
            using (var sqlCommand = sqlConnection.CreateCommand())
            {
                sqlCommand.CommandText = "select * from Suppliers where SupplierID = @id";
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlConnection.Open();
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        supplier = new Supplier()
                        {
                            Id = reader.GetInt32("SupplierID"),
                            CompanyName = reader.GetString("CompanyName"),
                            ContactName = reader.GetString("ContactName"),
                            ContactTitle = reader.GetString("ContactTitle"),
                            City = reader.GetString("City"),
                            Country = reader.GetString("Country"),
                            Address = reader.GetString("Address"),
                            PostalCode = reader.GetString("PostalCode"),
                            Region = reader.GetString("Region"),
                            Phone = reader.GetString("Phone"),
                            Fax = reader.GetString("Fax"),
                            HomePage = reader.GetString("HomePage"),
                        };
                    }
                    sqlConnection.Close();
                }
            }
            return supplier;
        }
        public List<Supplier> GetAll()
        {
            var suppliers = new List<Supplier>();
            using (var sqlConnection = new SqlConnection(DbSettings.ConnectionString))
            using (var sqlCommand = sqlConnection.CreateCommand())
            {
                sqlCommand.CommandText = "select * from Suppliers";
                sqlConnection.Open();
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        suppliers.Add(MapSupplier(reader));
                    }
                }
                sqlConnection.Close();
            }
            return suppliers;
        }
        public void Add(Supplier supplier)
        {
            using (var connection = new SqlConnection(DbSettings.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"insert into Suppliers ([CompanyName],[ContactName],ContactTitle,
[Address],[City],[Region],[PostalCode],[Country],[Phone],[Fax],HomePage) values (@companyName,@contactName,@contactTitle,
@address,@city,@region,@postalCode,@country,@phone,@fax,@homePage)";

                command.Parameters.AddWithValue("@companyName", supplier.CompanyName);
                command.Parameters.AddWithValue("@contactName", supplier.ContactName);
                command.Parameters.AddWithValue("@contactTitle", supplier.ContactTitle);
                command.Parameters.AddWithValue("@address", supplier.Address);
                command.Parameters.AddWithValue("@city", supplier.City);
                command.Parameters.AddWithValue("@region", supplier.Region);
                command.Parameters.AddWithValue("@postalCode", supplier.PostalCode);
                command.Parameters.AddWithValue("@country", supplier.Country);
                command.Parameters.AddWithValue("@phone", supplier.Phone);
                command.Parameters.AddWithValue("@fax", supplier.Fax);
                command.Parameters.AddWithValue("@homePage", supplier.HomePage);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update(Supplier supplier)
        {
            using (var connection = new SqlConnection(DbSettings.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"update Suppliers set CompanyName=@companyName,ContactName=@contactName,
ContactTitle=@contactTitle,Address=@address,City=@city,Region=@region,PostalCode=@postalCode,Country=@country,Phone=@phone,
Fax=@fax,HomePage=@homePage where SupplierID = @id";

                command.Parameters.AddWithValue("@id", supplier.Id);
                command.Parameters.AddWithValue("@companyName", supplier.CompanyName.ToDbValue());
                command.Parameters.AddWithValue("@contactName", supplier.ContactName == null ? DBNull.Value : supplier.ContactName);
                command.Parameters.AddWithValue("@contactTitle", supplier.ContactTitle.ToDbValue());
                command.Parameters.AddWithValue("@address", supplier.Address == null ? DBNull.Value : supplier.Address);
                command.Parameters.AddWithValue("@city", supplier.City == null ? DBNull.Value : supplier.City);
                command.Parameters.AddWithValue("@region", supplier.Region == null ? DBNull.Value : supplier.Region);
                command.Parameters.AddWithValue("@postalCode", supplier.PostalCode == null ? DBNull.Value : supplier.PostalCode);
                command.Parameters.AddWithValue("@country", supplier.Country == null ? DBNull.Value : supplier.Country);
                command.Parameters.AddWithValue("@phone", supplier.Phone == null ? DBNull.Value : supplier.Phone);
                command.Parameters.AddWithValue("@fax", supplier.Fax == null ? DBNull.Value : supplier.Fax);
                command.Parameters.AddWithValue("@homePage", supplier.HomePage == null ? DBNull.Value : supplier.HomePage);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Remove(Supplier supplier)
        {
            Remove(supplier.Id);
        }

        public void Remove(int id)
        {
            using (var connection = new SqlConnection(DbSettings.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "delete from Suppliers where SupplierID = @id";
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private Supplier MapSupplier(SqlDataReader reader)
        {
            return new Supplier()
            {
                Id = reader.GetInt32("SupplierID"),
                CompanyName = reader.GetStringNullable("CompanyName"),
                ContactName = reader.GetStringNullable("ContactName"),
                ContactTitle = reader.GetStringNullable("ContactTitle"),
                City = reader.GetStringNullable("City"),
                Country = reader.GetStringNullable("Country"),
                Address = reader.GetStringNullable("Address"),
                PostalCode = reader.GetStringNullable("PostalCode"),
                Region = reader.GetStringNullable("Region"),
                Phone = reader.GetStringNullable("Phone"),
                Fax = reader.GetStringNullable("Fax"),
                HomePage = reader.GetStringNullable("HomePage")
            };
        }
    }
}
