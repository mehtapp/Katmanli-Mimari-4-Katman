using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Facade
{
    public class EmployeeMethods
    {
        public static bool EmployeeLogin(employees emp1)
        {SqlCommand cmd = new SqlCommand("LoginEmployee", ConnectionforDb.con);
            try
            {
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("userName", emp1.EmployeeUserName);
                cmd.Parameters.AddWithValue("password", emp1.EmployeePassword);
                if (cmd.Connection.State!=ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                SqlDataReader dr=cmd.ExecuteReader();
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (cmd.Connection.State!=ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public static bool AddEmployee(employees emp1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddEmployee", ConnectionforDb.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nameSurname",emp1.EmployeeNameSurname);
                cmd.Parameters.AddWithValue("userName", emp1.EmployeeUserName);
                cmd.Parameters.AddWithValue("password", emp1.EmployeePassword);
                return ConnectionforDb.ExecuteNonQuery(cmd);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static List<employees> EmpList()
        {
            SqlCommand cmd = new SqlCommand("EmployeeList", ConnectionforDb.con);
            List<employees> EmpsList = new List<employees>();
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
                    while (reader.Read())
                    {
                        employees emp1 = new employees();
                        emp1.EmployeeID = Convert.ToInt32(reader["employeeId"]);
                        emp1.EmployeeNameSurname = reader["nameSurname"].ToString();
                        emp1.EmployeeUserName = reader["userName"].ToString();
                        emp1.EmployeePassword = reader["password"].ToString();
                        EmpsList.Add(emp1);
                    }
                }

            }
            catch (Exception)
            {
                EmpsList = null;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
            return EmpsList;


        }
    }
}
