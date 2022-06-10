using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC4LayerSalesManagementSystemProject
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerProcess customerPage = new CustomerProcess();
            customerPage.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsProcess productPage = new ProductsProcess();
            productPage.Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CategoryProcess categoryPage = new CategoryProcess();
            categoryPage.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrdersProcess ordersPage = new OrdersProcess();
            ordersPage.Show();
            this.Hide();
        }
    }
}
