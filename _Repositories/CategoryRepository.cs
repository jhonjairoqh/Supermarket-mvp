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
    internal class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CategoryModel categoryModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Categories (Category_Name, Category_Description) 
                                        VALUES (@name, @description)";
                command.Parameters.AddWithValue("@name", categoryModel.Name);
                command.Parameters.AddWithValue("@description", categoryModel.Description ?? (object)DBNull.Value);
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
                command.CommandText = "DELETE FROM Categories WHERE Category_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoryModel categoryModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Categories 
                                        SET Category_Name = @name,
                                            Category_Description = @description
                                        WHERE Category_Id = @id";
                command.Parameters.AddWithValue("@name", categoryModel.Name);
                command.Parameters.AddWithValue("@description", categoryModel.Description ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@id", categoryModel.Id);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            var categoryList = new List<CategoryModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Categories ORDER BY Category_Id DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoryModel
                        {
                            Id = (int)reader["Category_Id"],
                            Name = reader["Category_Name"].ToString(),
                            Description = reader["Category_Description"].ToString()
                        };
                        categoryList.Add(categoryModel);
                    }
                }
            }
            return categoryList;
        }

        public IEnumerable<CategoryModel> GetByValue(string value)
        {
            var categoryList = new List<CategoryModel>();
            int categoryId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categoryName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Categories 
                                        WHERE Category_Id = @id OR Category_Name LIKE @name + '%' 
                                        ORDER BY Category_Id DESC";
                command.Parameters.AddWithValue("@id", categoryId);
                command.Parameters.AddWithValue("@name", categoryName);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoryModel
                        {
                            Id = (int)reader["Category_Id"],
                            Name = reader["Category_Name"].ToString(),
                            Description = reader["Category_Description"].ToString()
                        };
                        categoryList.Add(categoryModel);
                    }
                }
            }
            return categoryList;
        }
    }
    
}
