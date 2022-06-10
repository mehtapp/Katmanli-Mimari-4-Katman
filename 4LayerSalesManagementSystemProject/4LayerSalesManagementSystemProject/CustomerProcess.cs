using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessORM;
using Entity;

namespace MVC4LayerSalesManagementSystemProject
{
    public partial class CustomerProcess : Form
    {
        public CustomerProcess()
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
            this.Hide();
        }
        
        private void btnCustAdd_Click(object sender, EventArgs e)
        {
            customers cust1 = new customers();
            if (txtCustNameSurName.Text!=null && txtCustNameSurName.Text.Trim().Length>0 && txtCustAdress.Text!=null && 
                txtCustAdress.Text.Trim().Length > 0 && txtCustMail.Text != null && txtCustMail.Text.Trim().Length > 0
                && maskedTextCustPhone.Text != null && maskedTextCustPhone.Text.Trim().Length > 0)
            {
                if (!CallCustomerMethods.listofCustomers().Any(p => p.CustomerMail == txtCustMail.Text || p.CustomerPhone == maskedTextCustPhone.Text))
                {
                    cust1.CustomerNameSurname = txtCustNameSurName.Text.Trim();
                    cust1.CustomerAdress = txtCustAdress.Text.Trim();
                    cust1.CustomerMail = txtCustMail.Text.Trim();
                    cust1.CustomerPhone = maskedTextCustPhone.Text.Trim();
                    if (!CallCustomerMethods.AddCustomer(cust1))
                    {
                        MessageBox.Show("Müşteri eklenemedi.");
                    }
                    else
                    {
                        ClearAllBox();
                    }
                }
                else
                {
                    MessageBox.Show("Sistemde başkası adına kayıtlı olan telefon veya mail adresini tekrar kayıt etmeye çalışıyorsunuz. Bu alanları değiştiriniz.");
                }
            }else
            {
                MessageBox.Show("Gerekli alanları boş bırakamazsınız. ");
            }
            ListCustomers();
        }
        public void ListCustomers()
        {
            dataGridView1.DataSource = CallCustomerMethods.listofCustomers();
        }
        private void btnCustList_Click(object sender, EventArgs e)
        {
            ListCustomers();
        }

        private void btnCustUpd_Click(object sender, EventArgs e)
        {
            customers cust1 = new customers();
            if (txtCustNameSurName.Text != null && txtCustNameSurName.Text.Trim().Length > 0 && txtCustAdress.Text != null &&
                txtCustAdress.Text.Trim().Length > 0 && txtCustMail.Text != null && txtCustMail.Text.Trim().Length > 0
                && maskedTextCustPhone.Text != null && maskedTextCustPhone.Text.Trim().Length > 0)
            {

                cust1.CustomerId = (int)txtCustNameSurName.Tag;
                cust1.CustomerNameSurname = txtCustNameSurName.Text.Trim(); ;
                cust1.CustomerAdress = txtCustAdress.Text.Trim(); ;
                cust1.CustomerMail = txtCustMail.Text.Trim(); ;
                cust1.CustomerPhone = maskedTextCustPhone.Text.Trim();
                if (!CallCustomerMethods.UpdateCustomer(cust1))
                {
                    MessageBox.Show("Güncelleme işlemiyle ilgili bir hata oluştu. Başka kişilerin mail ve telefonunu girmediğinize emin olunuz.");
                }
                else
                {
                    ClearAllBox();ListCustomers();
                }
            }
            else
            {
                MessageBox.Show("İlgili alanlar boş olamaz.");
            }
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtCustNameSurName.Tag = row.Cells["CustomerId"].Value;
            txtCustNameSurName.Text = row.Cells["CustomerNameSurname"].Value.ToString() ;
            txtCustAdress.Text = row.Cells["CustomerAdress"].Value.ToString();
            txtCustMail.Text = row.Cells["CustomerMail"].Value.ToString();
            maskedTextCustPhone.Text = row.Cells["CustomerPhone"].Value.ToString();
        }
        private void btnCustDel_Click(object sender, EventArgs e)
        {
            customers cust1 = new customers();
            cust1.CustomerId = (int)txtCustNameSurName.Tag;
            if (!CallCustomerMethods.DelCustomer(cust1))
            {
                MessageBox.Show("Silme işlemi başarısız. Silme istediğiniz Müşteriyi seçtiğinize emin misiniz?");
            }
            else
            {
                ClearAllBox();
                ListCustomers();
            }
            
        }
        public void ClearAllBox()
        {
            txtCustNameSurName.Clear();
            txtCustAdress.Clear();
            txtCustMail.Clear();
            maskedTextCustPhone.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllBox();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeLoginandSignUp logOut = new EmployeeLoginandSignUp();
            logOut.Show();
            this.Hide();
        }
    }
}
