﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.Models;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class PayModeRepository : BaseRepository, IPayModeRepository
    {
        public PayModeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(PayModeModel payModeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO PayMode VALUES (@name, @observation)";
                command.Parameters.AddWithValue("@name",
                payModeModel.Name);
                command.Parameters.AddWithValue("@observation", payModeModel.Observation);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection
         = connection;
                command.CommandText = "DELETE FROM PayMode WHERE Pay_Mode_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(PayModeModel payModeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE PayMode
                                     SET Pay_Mode_Name = @name,
                                     Pay_Mode_Observation = @observation
                                     WHERE Pay_Mode_Id = @id";
                command.Parameters.Add("@name",SqlDbType.VarChar).Value = payModeModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = payModeModel.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = payModeModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<PayModeModel> GetAll()
        {
            var PayModeList = new List<PayModeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM PayMode ORDER BY Pay_Mode_Id DESC";
                using (var reader = command.ExecuteReader())

                {
                    while (reader.Read())
                    {
                        var PayModeModel = new PayModeModel();
                        PayModeModel.Id = (int)reader["Pay_Mode_Id"];
                        PayModeModel.Name = reader["Pay_Mode_Name"].ToString();
                        PayModeModel.Observation = reader["Pay_Mode_Observation"].ToString();
                        PayModeList.Add(PayModeModel);
                    }
                }
            }
            return PayModeList;
        }

        public IEnumerable<PayModeModel> GetByValue(string value)
        {
            var payModeList = new List<PayModeModel>();
            int payModeId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string payModeName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM PayMode
                                WHERE Pay_Mode_Id=@id OR Pay_Mode_Name LIKE @name+'%'
                                ORDER BY Pay_Mode_Id DESC";
                command.Parameters.AddWithValue("@id",
         SqlDbType.Int).Value = payModeId;
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = payModeName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var payModeModel = new PayModeModel();
                        payModeModel.Id = (int)reader["Pay_Mode_Id"];
                        payModeModel.Name = reader["Pay_Mode_Name"].ToString();
                        payModeModel.Observation = reader["Pay_Mode_Observation"].ToString();
                        payModeList.Add(payModeModel);
                    }
                }
            }

            return payModeList;
        }
    }
}
