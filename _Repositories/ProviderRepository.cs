using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class ProviderRepository : BaseRepository, IProviderRepository
    {
        public ProviderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ProviderModel providerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Providers (Provider_Name, Provider_Contact, ProviderAddress) 
                                        VALUES (@name, @contact, @address)";
                command.Parameters.AddWithValue("@name", providerModel.Name);
                command.Parameters.AddWithValue("@contact", providerModel.Contact);
                command.Parameters.AddWithValue("@address", providerModel.Address);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Providers WHERE Provider_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProviderModel providerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Providers 
                                        SET Provider_Name = @name,
                                            Provider_Contact = @contact,
                                            ProviderAddress = @address
                                        WHERE Provider_Id = @id";
                command.Parameters.AddWithValue("@name", providerModel.Name);
                command.Parameters.AddWithValue("@contact", providerModel.Contact);
                command.Parameters.AddWithValue("@address", providerModel.Address);
                command.Parameters.AddWithValue("@id", providerModel.Id);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProviderModel> GetAll()
        {
            var providerList = new List<ProviderModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Providers ORDER BY Provider_Id DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providerModel = new ProviderModel
                        {
                            Id = (int)reader["Provider_Id"],
                            Name = reader["Provider_Name"].ToString(),
                            Contact = reader["Provider_Contact"].ToString(),
                            Address = reader["ProviderAddress"].ToString()
                        };
                        providerList.Add(providerModel);
                    }
                }
            }
            return providerList;
        }

        public IEnumerable<ProviderModel> GetByValue(string value)
        {
            var providerList = new List<ProviderModel>();
            int providerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string providerName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Providers 
                                        WHERE Provider_Id = @id OR Provider_Name LIKE @name + '%' 
                                        ORDER BY Provider_Id DESC";
                command.Parameters.AddWithValue("@id", providerId);
                command.Parameters.AddWithValue("@name", providerName);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providerModel = new ProviderModel
                        {
                            Id = (int)reader["Provider_Id"],
                            Name = reader["Provider_Name"].ToString(),
                            Contact = reader["Provider_Contact"].ToString(),
                            Address = reader["ProviderAddress"].ToString()
                        };
                        providerList.Add(providerModel);
                    }
                }
            }
            return providerList;
        }
    }
}
    
