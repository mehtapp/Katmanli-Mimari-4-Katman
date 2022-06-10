using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Facade
{
    public class OrderMethods
    {
        public static List<orders> OrderList()
        {
            //değerler boş girilirse sorun yaratıyor
            SqlCommand cmd = new SqlCommand("OrderList", ConnectionforDb.con);
            List<orders> AllOrders = new List<orders>();
            try
            {

                cmd.CommandType = CommandType.StoredProcedure;
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        orders orders1 = new orders();
                        orders1.OrderID = Convert.ToInt32(reader["OrderID"]);
                        orders1.ProductID= Convert.ToInt32(reader["ProductId"]);
                        orders1.CustomerID = Convert.ToInt32(reader["CustomerId"]);
                        orders1.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                        orders1.DeliveryDate = Convert.ToDateTime(reader["DeliveryDate"]);
                        orders1.Quantity = Convert.ToInt32(reader["Quantity"]);
                        orders1.TotalPrice = Convert.ToDecimal(reader["TotalPrice"]);
                        orders1.DeliveryStatus = reader["DeliveryStatus"].ToString();
                        orders1.EmployeeID = Convert.ToInt32(reader["employeeId"]);
                        AllOrders.Add(orders1);
                    }
                }
            }
            catch (Exception)
            {
                AllOrders = null;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
            return AllOrders;

        }
        
        public static bool AddOrder(orders order1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddOrder", ConnectionforDb.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ProductId", order1.ProductID);
                cmd.Parameters.AddWithValue("CustomerId", order1.CustomerID);
                cmd.Parameters.AddWithValue("DeliveryDate", order1.DeliveryDate);
                
                
                cmd.Parameters.AddWithValue("Quantity", order1.Quantity);
                cmd.Parameters.AddWithValue("TotalPrice", order1.TotalPrice);
                cmd.Parameters.AddWithValue("DeliveryStatus", order1.DeliveryStatus);
                cmd.Parameters.AddWithValue("employeeId", order1.EmployeeID);
                return ConnectionforDb.ExecuteNonQuery(cmd);
                
            }
            catch (Exception)
            {
                return false;
            }
        }
    
        public static bool UpdateOrder(orders order1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateOrder", ConnectionforDb.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("OrderId", order1.OrderID);
                cmd.Parameters.AddWithValue("ProductId", order1.ProductID);
                cmd.Parameters.AddWithValue("CustomerId", order1.CustomerID);
                cmd.Parameters.AddWithValue("DeliveryDate", order1.DeliveryDate);
                cmd.Parameters.AddWithValue("DeliveryStatus", order1.DeliveryStatus);
                cmd.Parameters.AddWithValue("Quantity", order1.Quantity);
                cmd.Parameters.AddWithValue("TotalPrice", order1.TotalPrice);
                cmd.Parameters.AddWithValue("employeeId", order1.EmployeeID);
                return ConnectionforDb.ExecuteNonQuery(cmd);
            }
            catch (Exception)
            {
                return false;
            }
        }
    
        public static bool DeleteOrder(orders order1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteOrder", ConnectionforDb.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("OrderId", order1.OrderID);
                return ConnectionforDb.ExecuteNonQuery(cmd);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
