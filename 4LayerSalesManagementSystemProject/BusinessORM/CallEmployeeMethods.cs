using Entity;
using Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessORM
{
    public class CallEmployeeMethods
    {

        public static bool CallEmployeeLogin(employees employee1)
        {
            return EmployeeMethods.EmployeeLogin(employee1);
        }
        public static bool AddEmployee(employees emp1)
        {
            return EmployeeMethods.AddEmployee(emp1);
        }
        public static List<employees> EmployeeList()
        {
            
            return EmployeeMethods.EmpList();
        }
    }
}
