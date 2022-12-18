using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNorthwind.DataAccess
{
    public class EmployeeRepository
    {
        public Employee GetById(int id)
        {
            Employee employee = null;
            using (var connection = new SqlConnection(DbSettings.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Employees where EmployyeeID = @id";
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        employee = MapEmployee(reader);
                    }
                    connection.Close();
                }
            }
            return employee;
        }
        public List<Employee> GetAll()
        {
            var employee = new List<Employee>();
            using (var connection = new SqlConnection(DbSettings.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from Employees";
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employee.Add(MapEmployee(reader));
                    }
                }
                connection.Close();
            }
            return employee;
        }
        private Employee MapEmployee(SqlDataReader reader)
        {
            return new Employee()
            {
                Id = reader.GetInt32("EmployeeID"),
                Name = reader.GetStringNullable("FirstName"),
                Surname = reader.GetStringNullable("LastName"),
                Title = reader.GetStringNullable("Title"),
                TitleOfCourtesy = reader.GetStringNullable("TitleOfCourtesy"),
                //TODO datetime data helper bak
                //BirthDate = reader.GetDateTimeNullable("BirthDate"),
                //HireDate = reader.GetDateTimeNullable("HireDate"),
                Address = reader.GetStringNullable("Address"),
                City = reader.GetStringNullable("City"),
                Region = reader.GetStringNullable("Region"),
                PostalCode = reader.GetStringNullable("PostalCode"),
                Country = reader.GetStringNullable("Country"),
                HomePhone = reader.GetStringNullable("HomePage"),
                Extension = reader.GetStringNullable("Extension"),
                Notes = reader.GetStringNullable("Notes"),
                ReportTo = reader.GetInt32("ReportTo"),
            };
        }
    }
}
