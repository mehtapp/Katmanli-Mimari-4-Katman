using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;

namespace BusinessORM
{
    public class CallProductsMethods
    {
        public static int AddProduct(products product1)
        {
            return ProductMethods.AddProduct(product1);
        }

        public static List<products> productList()
        {
            return ProductMethods.ListProduct();
        }
        public static int UpdateProduct(products pro1)
        {
            return ProductMethods.UpdateProduct(pro1);
        }
        public static int DelProduct(products product1)
        {
            return ProductMethods.DeleteProduct(product1);
        }
    }
}
