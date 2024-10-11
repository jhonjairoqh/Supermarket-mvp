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
    internal class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Products (Product_Name, Product_Price, Product_Stock, Category_Id) 
                                        VALUES (@name, @price, @stock, @categoryId)";
                command.Parameters.AddWithValue("@name", productModel.Name);
                command.Parameters.AddWithValue("@price", productModel.Price);
                command.Parameters.AddWithValue("@stock", productModel.Stock);
                command.Parameters.AddWithValue("@categoryId", productModel.CategoryId);
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
                command.CommandText = "DELETE FROM Products WHERE Product_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Products 
                                        SET Product_Name = @name,
                                            Product_Price = @price,
                                            Product_Stock = @stock,
                                            Category_Id = @categoryId
                                        WHERE Product_Id = @id";
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.AddWithValue("@price", SqlDbType.Decimal).Value = productModel.Price;
                command.Parameters.AddWithValue("@stock", SqlDbType.Int).Value = productModel.Stock;
                command.Parameters.AddWithValue("@categoryId", SqlDbType.Int).Value = productModel.CategoryId;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = productModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Products ORDER BY Product_Id DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Id = (int)reader["Product_Id"];
                        productModel.Name = reader["Product_Name"].ToString();
                        productModel.Price = (decimal)reader["Product_Price"];
                        productModel.Stock = (int)reader["Product_Stock"];
                        productModel.CategoryId = (int)reader["Category_Id"];
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }

        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var productList = new List<ProductModel>();
            int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Products 
                                        WHERE Product_Id = @id OR Product_Name LIKE @name + '%' 
                                        ORDER BY Product_Id DESC";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = productId;
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = productName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Id = (int)reader["Product_Id"];
                        productModel.Name = reader["Product_Name"].ToString();
                        productModel.Price = (decimal)reader["Product_Price"];
                        productModel.Stock = (int)reader["Product_Stock"];
                        productModel.CategoryId = (int)reader["Category_Id"];
                        productList.Add(productModel);
                    }
                }
            }

            return productList;
        }
    }
}
