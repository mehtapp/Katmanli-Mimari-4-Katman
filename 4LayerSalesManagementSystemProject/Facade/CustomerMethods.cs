using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Facade
{
    public class CustomerMethods
    {
        public static bool AddCustomer(customers customer1)
        {
           try
            {
                SqlCommand cmd = new SqlCommand("AddCustomer", ConnectionforDb.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NameSurname", customer1.CustomerNameSurname);
                cmd.Parameters.AddWithValue("adress", customer1.CustomerAdress);
                cmd.Parameters.AddWithValue("mail", customer1.CustomerMail);
                cmd.Parameters.AddWithValue("phone", customer1.CustomerPhone);
                return ConnectionforDb.ExecuteNonQuery(cmd);
                    
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static List<customers> listCustomer()
        {
            SqlCommand cmd= new SqlCommand("CustomerList", ConnectionforDb.con);
            List<customers> CustomersList= new List<customers>();
            try
            {
                cmd.CommandType=CommandType.StoredProcedure;
                if (cmd.Connection.State!=ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                SqlDataReader reader=cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        customers cust1=new customers();
                        cust1.CustomerId = (int)reader["CustomerId"];
                        cust1.CustomerNameSurname = reader["CustomerNameSurname"].ToString();
                        cust1.CustomerAdress = reader["CustomerAdress"].ToString();
                        cust1.CustomerMail = reader["CustomerMail"].ToString();
                        cust1.CustomerPhone = reader["CustomerPhone"].ToString();
                        CustomersList.Add(cust1);
                    }
                }

            }
            catch(Exception)
            {
                CustomersList = null;
            }
            finally
            {
                if (cmd.Connection.State!=ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
            return CustomersList;
        }

        public static bool UpdateCustomer(customers customer1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateCustomer", ConnectionforDb.con);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("custId", customer1.CustomerId);
                cmd.Parameters.AddWithValue("NameSurname", customer1.CustomerNameSurname);
                cmd.Parameters.AddWithValue("adress", customer1.CustomerAdress);
                cmd.Parameters.AddWithValue("mail", customer1.CustomerMail);
                cmd.Parameters.AddWithValue("phone", customer1.CustomerPhone);
                return ConnectionforDb.ExecuteNonQuery(cmd);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DeleteCustomer(customers customer1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DelCustomer", ConnectionforDb.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("custId", customer1.CustomerId);
                return ConnectionforDb.ExecuteNonQuery(cmd);
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
