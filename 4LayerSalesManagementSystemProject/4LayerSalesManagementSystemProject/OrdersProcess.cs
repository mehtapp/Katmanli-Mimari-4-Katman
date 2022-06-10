using BusinessORM;
using Entity;
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
    public partial class OrdersProcess : Form
    {
        public OrdersProcess()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsProcess productPage = new ProductsProcess();
            productPage.Show();
            this.Hide();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerProcess customerPage = new CustomerProcess();
            customerPage.Show();
            this.Hide();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryProcess categoryPage = new CategoryProcess();
            categoryPage.Show();
            this.Hide();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersProcess ordersPage = new OrdersProcess();
            ordersPage.Show();
            this.Hide();
        }

        private void refToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void listOfOrder()
        {
            dataGridView1.DataSource = CallOrderMethods.OrderList();
        }
        private void btnOrderList_Click(object sender, EventArgs e)
        {
            listOfOrder();
        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            orders newOrder= new orders();
            if ((txtQuantity.Text!="" || txtQuantity.Text.Trim().Length>0) && (txtTotalPrice.Text!="" &&  txtTotalPrice.Text.Trim().Length>0)
                 )
            {

                newOrder.ProductID = Convert.ToInt32(comboBoxProdNameandId.SelectedValue);
                newOrder.CustomerID = Convert.ToInt32(comboBoxCustomerNameandId.SelectedValue);
                if (comboBoxDeliveryStatus.Text == "" && comboBoxDeliveryStatus.SelectedValue == null)
                {
                    newOrder.DeliveryStatus = "Sipariş Hazırlanıyor";
                }
                else
                {
                    newOrder.DeliveryStatus = comboBoxDeliveryStatus.Text;
                }
                if (!maskedTextBoxDeliveryDate.MaskFull)
                {
                    newOrder.DeliveryDate = new DateTime(1999,11,11);
                }
                else
                {
                    newOrder.DeliveryDate = Convert.ToDateTime(maskedTextBoxDeliveryDate.Text);
                }

                newOrder.Quantity = Convert.ToInt32(txtQuantity.Text);
                newOrder.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
                newOrder.EmployeeID = Convert.ToInt32(lblEmployeeName.Tag);
               
                if (!CallOrderMethods.AddOrder(newOrder))
                {
                    MessageBox.Show("Sipariş kaydı yapılamadı. Bir üründen 2 den fazla alamazsınız");
                }
                else
                {
                    listOfOrder();
                }
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz.");
            }
        }

        private void OrdersProcess_Load(object sender, EventArgs e)
        {
            maskedTextBoxOrderDate.Text = DateTime.Now.ToString();
            comboBoxCustomerNameandId.DataSource = CallCustomerMethods.listofCustomers();
            comboBoxCustomerNameandId.ValueMember = "CustomerId";
            comboBoxCustomerNameandId.DisplayMember = "CustomerNameSurname";
            comboBoxProdNameandId.DataSource = CallProductsMethods.productList();
            comboBoxProdNameandId.DisplayMember = "ProductName";
            comboBoxProdNameandId.ValueMember = "ProductId";
            employees activeEmployee= EmployeeLoginandSignUp.ActiveEmployee;
            lblEmployeeName.Text = CallEmployeeMethods.EmployeeList().Find(p => p.EmployeeUserName == activeEmployee.EmployeeUserName &&
            p.EmployeePassword == activeEmployee.EmployeePassword).EmployeeNameSurname.ToString();
            lblEmployeeName.Tag=CallEmployeeMethods.EmployeeList().Find(p=>p.EmployeeUserName == activeEmployee.EmployeeUserName &&
            p.EmployeePassword == activeEmployee.EmployeePassword).EmployeeID;
           
           
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderUpd_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "" && txtQuantity.Text.Trim().Length > 0 && txtTotalPrice.Text != "" && txtTotalPrice.Text.Trim().Length > 0)
            {
                orders order1 = new orders();
                order1.OrderID = Convert.ToInt32(txtTotalPrice.Tag);
                order1.CustomerID = Convert.ToInt32(comboBoxCustomerNameandId.SelectedValue);
                order1.ProductID = Convert.ToInt32(comboBoxProdNameandId.SelectedValue);
                try
                {
                    order1.DeliveryDate = Convert.ToDateTime(maskedTextBoxDeliveryDate.Text);
                }catch (Exception)
                {
                   
                }
                
                order1.Quantity= Convert.ToInt32(txtQuantity.Text);
                order1.TotalPrice= Convert.ToDecimal(txtTotalPrice.Text);
                order1.DeliveryStatus =comboBoxDeliveryStatus.Text;
                order1.EmployeeID = Convert.ToInt32(lblEmployeeName.Tag);
                if (!CallOrderMethods.UpdateOrder(order1))
                {
                    MessageBox.Show("Güncelle işlemi başarısız. Bir üründen 2 den fazla alamazsınız");
                }
                listOfOrder();
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            comboBoxCustomerNameandId.Text = CallCustomerMethods.listofCustomers().Find(p => p.CustomerId == 
            Convert.ToInt32(row.Cells["CustomerID"].Value)).CustomerNameSurname.ToString();


            comboBoxProdNameandId.Text = CallProductsMethods.productList().Find(p => p.ProductId ==
              Convert.ToInt32(row.Cells["ProductID"].Value)).ProductName.ToString();
            
            maskedTextBoxOrderDate.Text = row.Cells["OrderDate"].Value.ToString();
            maskedTextBoxDeliveryDate.Text= row.Cells["DeliveryDate"].Value.ToString();

            txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
            txtTotalPrice.Text = row.Cells["TotalPrice"].Value.ToString();
            comboBoxDeliveryStatus.Text = row.Cells["DeliveryStatus"].Value.ToString();
            txtTotalPrice.Tag = row.Cells["OrderID"].Value;
        }

        private void btnOrderDel_Click(object sender, EventArgs e)
        {
            orders ord = new orders();
            ord.OrderID = (int)txtTotalPrice.Tag;
            if (!CallOrderMethods.DeleteOrder(ord))
            {
                MessageBox.Show(ord.OrderID+ " Silme işlemi başarısız. Daha sonra tekrar deneyiniz.");
            }
                listOfOrder();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeLoginandSignUp logOut = new EmployeeLoginandSignUp();
            logOut.Show();
            this.Hide();
        }
    }
}
