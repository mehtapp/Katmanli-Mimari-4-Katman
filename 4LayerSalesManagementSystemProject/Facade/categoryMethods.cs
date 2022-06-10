using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;


namespace Facade
{
    public class categoryMethods
    {
    
        public static List<categories> listcategory()
        {
            List<categories> itemlist = null;
            SqlCommand cmd = new SqlCommand("CategoryList", ConnectionforDb.con);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemlist = new List<categories>();
                    while (rdr.Read())
                    {
                        categories item = new categories();
                        item.CategoryID = (rdr["CategoryId"].ToString());
                        item.CategoryName = rdr["CategoryName"].ToString();
                        itemlist.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                itemlist = null;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return itemlist;
        }
        public static bool AddCategory(categories cat1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddCategory", ConnectionforDb.con);
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Parameters.AddWithValue("CategoryName", cat1.CategoryName);

               return ConnectionforDb.ExecuteNonQuery(cmd);
                
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool UpdateCategory(categories cat1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateCategory", ConnectionforDb.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CategoryId", cat1.CategoryID);
                cmd.Parameters.AddWithValue("CategoryName", cat1.CategoryName);
                return ConnectionforDb.ExecuteNonQuery(cmd); // Bağlantı açma kapama ve işlem(CRUD) gerçekleşti gerçekleşmedi kontrolü
                //gerçekleştiyse true döndürür.
            }
            catch(Exception)
            {
                return false;
            }
        }
    
        public static bool DeleteCategory(categories cat1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteCategory", ConnectionforDb.con);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CategoryId", cat1.CategoryID);
                return ConnectionforDb.ExecuteNonQuery(cmd);
            }
            catch(Exception)
            {
                return false;
                
            }
            
        }
    
    
    }

}
