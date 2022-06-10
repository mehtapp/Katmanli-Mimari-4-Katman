using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class products
    {
        private int prodId;

        public int ProductId
        {
            get { return prodId; }
            set { prodId = value; }
        }
        private string prodName;

        public string ProductName
        {
            get { return prodName; }
            set { prodName = value; }
        }
        private int prodUnitPrice;

        public int ProductUnitPrice
        {
            get { return prodUnitPrice; }
            set { prodUnitPrice = value; }
        }
        private string categoryId;
        public string CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }
    }
}
