using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNorthwind.DataAccess
{
    public class ProductRepository
    {
        public Product GetById(int id)
        {
            Product product = null;
            using (var connection = new SqlConnection(DbSettings.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Products where ProductID = @id";
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                using(var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        product = MapProduct(reader);
                    }
                    connection.Close();
                }
            }
            return product;
        }
        public List<Product> GetAll()
        {
            var products = new List<Product>();
            using (var connection = new SqlConnection(DbSettings.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Products";
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(MapProduct(reader));
                    }
                }
                connection.Close();
            }
            return products;
        }
        public void Add(Product product)
        {
            using (var connection = new SqlConnection(DbSettings.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"insert into Products(ProductName, SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,
ReorderLevel,Discontinued) 
values (@name,@supplierId,@categoryId,@quantityPerUnit,@unitPrice,@unitsInStock,@unitsOnOrder,@reorderLevel,@discontinued)";
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@supplierId", product.SupplierId);
                command.Parameters.AddWithValue("@categoryId", product.CategoryId);
                command.Parameters.AddWithValue("@quantityPerUnit", product.QuantityPerUnit);
                command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
                command.Parameters.AddWithValue("@unitsInStock", product.UnitsInStock);
                command.Parameters.AddWithValue("@unitsOnOrder", product.UnitsOnOrder);
                command.Parameters.AddWithValue("@reorderLevel", product.ReorderLevel);
                command.Parameters.AddWithValue("@discontinued", product.Discontinued);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Update(Product product)
        {
            using (var connection = new SqlConnection(DbSettings.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"update Products set ProductName = @name, SupplierID = @supplierId,
CategoryID=@categoryId,QuantityPerUnit=@quantityPerUnit,UnitPrice=@unitPrice,UnitsInStock=@unitsInStock,UnitsOnOrder=@unitsOnOrder,
ReorderLevel=@reorderLevel,Discontinued=@discontinued where ProductID = @id";

                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@supplierId", product.SupplierId);
                command.Parameters.AddWithValue("@categoryId", product.CategoryId);
                command.Parameters.AddWithValue("@quantityPerUnit", product.QuantityPerUnit);
                command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
                command.Parameters.AddWithValue("@unitsInStock", product.UnitsInStock);
                command.Parameters.AddWithValue("@unitsOnOrder", product.UnitsOnOrder);
                command.Parameters.AddWithValue("@reorderLevel", product.ReorderLevel);
                command.Parameters.AddWithValue("@discontinued", product.Discontinued);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Remove(Product product)
        {
            Remove(product.Id);
        }

        public void Remove(int id)
        {
            using (var connection = new SqlConnection(DbSettings.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "delete from Products where ProductID = @id";
                command.Parameters.AddWithValue("id", id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private Product MapProduct(SqlDataReader reader)
        {
            return new Product()
            {
                Id = reader.GetInt32("ProductID"),
                Name = reader.GetStringNullable("ProductName"),
                SupplierId = reader.GetInt32Nullable("SupplierID"),
                CategoryId = reader.GetInt32Nullable("CategoryID"),
                QuantityPerUnit = reader.GetStringNullable("QuantityPerUnit"),
                UnitPrice = reader.GetDecimalNullable("UnitPrice"),
                UnitsInStock = reader.GetInt16Nullable("UnitsInStock"),
                UnitsOnOrder = reader.GetInt16Nullable("UnitsOnOrder"),
                ReorderLevel = reader.GetInt16Nullable("ReorderLevel"),
                Discontinued = reader.GetBoolean("Discontinued"),
            };
        }
    }
}
