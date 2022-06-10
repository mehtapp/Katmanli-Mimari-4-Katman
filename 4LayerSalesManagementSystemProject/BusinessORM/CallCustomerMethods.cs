using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;

namespace BusinessORM
{
    public class CallCustomerMethods
    {
        public static List<customers> listofCustomers()
        {
            
                return CustomerMethods.listCustomer();
            
        }
        public static bool AddCustomer(customers cust1)
        {
            return CustomerMethods.AddCustomer(cust1);
        }
        public static bool UpdateCustomer(customers cust1)
        {
            return CustomerMethods.UpdateCustomer(cust1);
        }

        public static bool DelCustomer(customers cust1)
        {
            return CustomerMethods.DeleteCustomer(cust1);
        }
    }
}
