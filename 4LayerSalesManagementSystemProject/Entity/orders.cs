using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class orders
    {
        private int orderId;

        public int OrderID
        {
            get { return orderId; }
            set { orderId = value ; }
        }

        private int productId;

        public int ProductID
        {
            get { return productId; }
            set { productId = value; }
        }

        private int CustId;

        public int CustomerID
        {
            get { return CustId; }
            set { CustId = value; }
        }
        private DateTime orderDate;

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        private DateTime deliveryDate;

        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private decimal totalPrice;

        public decimal TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        private string deliveryStatus;

        public string DeliveryStatus
        {
            get { return deliveryStatus; }
            set { deliveryStatus = value; }
        }
        private int employeeId;

        public int EmployeeID
        {
            get { return employeeId; }
            set { employeeId = value; }
        }



    }
}
