using Entity;
using Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessORM
{
    public class CallOrderMethods
    {
        public static List<orders> OrderList()
        {
            return OrderMethods.OrderList();
        }
        public static bool AddOrder(orders order1)
        {
            return OrderMethods.AddOrder(order1);
        }

        public static bool UpdateOrder(orders order1)
        {
            return OrderMethods.UpdateOrder(order1);
        }
        public static bool DeleteOrder(orders order1)
        {
            return OrderMethods.DeleteOrder(order1);
        }
    }
}
