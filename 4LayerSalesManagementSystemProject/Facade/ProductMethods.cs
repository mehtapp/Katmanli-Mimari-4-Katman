using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;
using System.Runtime.InteropServices;

namespace Facade
{
    public class ProductMethods
    {
        public static int AddProduct(products product)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddProduct", ConnectionforDb.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("productName", product.ProductName);
                cmd.Parameters.AddWithValue("unitPrice", product.ProductUnitPrice);
                cmd.Parameters.AddWithValue("catId", product.CategoryId);
                if (ConnectionforDb.ExecuteNonQuery(cmd))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }catch (Exception)
            {
                return -1;
            }
            
        }

        public static List<products> ListProduct()
        {
            List<products> products1= new List<products>();
            SqlCommand cmd = new SqlCommand("ProductList", ConnectionforDb.con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (cmd.Connection.State!=ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                SqlDataReader dr= cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    
                    while (dr.Read())
                    {
                        products pro1 = new products();
                        pro1.ProductId = (int)dr["ProductId"];
                        pro1.ProductName=dr["ProductName"].ToString();
                        pro1.ProductUnitPrice=  Convert.ToInt32(dr["UnitPrice"]);
                        pro1.CategoryId =dr["CategoryId"].ToString();
                        products1.Add(pro1);
                    }
                }
                return products1;

            }
            catch(Exception)
            {
                return null;
            }
            finally
            {
                if (cmd.Connection.State!=ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public static int UpdateProduct(products pro1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateProduct", ConnectionforDb.con);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("productName", pro1.ProductName);
                cmd.Parameters.AddWithValue("unitPrice", pro1 .ProductUnitPrice);
                cmd.Parameters.AddWithValue("catId", pro1.CategoryId);
                cmd.Parameters.AddWithValue("productId", pro1.ProductId);
                if (ConnectionforDb.ExecuteNonQuery(cmd))
                {
                    return 1;
                }
                else {
                    return 0; }
            }
            catch(Exception)
            {
                return -1;
            }

        }

        public static int DeleteProduct(products pro1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DelProduct", ConnectionforDb.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("productId", pro1.ProductId);
                if (ConnectionforDb.ExecuteNonQuery(cmd))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch(Exception)
            {
                return -1;
            }

        }
    }
}
