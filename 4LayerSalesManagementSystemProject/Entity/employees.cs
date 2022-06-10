using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class employees
    {
        private int empId;

        public int EmployeeID
        {
            get { return empId; }
            set { empId = value; }
        }
        private string empUserName;

        public string EmployeeUserName
        {
            get { return empUserName; }
            set { empUserName = value; }
        }
        private string empPassword;

        public string EmployeePassword
        {
            get { return empPassword; }
            set { empPassword = value; }
        }
        private string empNameSurName;

        public string EmployeeNameSurname
        {
            get { return empNameSurName; }
            set { empNameSurName = value; }
        }



    }

}
