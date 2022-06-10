using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessORM;
using Entity;

namespace MVC4LayerSalesManagementSystemProject
{
    public partial class ProductsProcess : Form
    {
        public ProductsProcess()
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
        private void btnProdAdd_Click(object sender, EventArgs e)
        {
            products product1 = new products();
            if (txtProdName.Text != "" && txtProdName.Text.Trim().Length > 0 && txtProdUnitPrice.Text != "" &&
                txtProdUnitPrice.Text.Trim().Length > 0  ) //catıd seçiliyse ekle
            {
                product1.ProductName = txtProdName.Text.Trim();
                product1.ProductUnitPrice = Convert.ToInt32(txtProdUnitPrice.Text);
                product1.CategoryId = comboBoxCatIdandName.SelectedValue.ToString();
                if (CallProductsMethods.AddProduct(product1)<1)
                {
                    MessageBox.Show("Kayıt sırasında bir hata oluştu. Daha sonra tekrar deneyiniz.");
                }
                else
                {
                    listofProduct();
                    clearAllBox();
                    
                    
                }
            }
            else
            {
                MessageBox.Show("Bilgileri doğru bir şekilde girmediniz. Tekrar Deneyiniz.");
            }
        }
        public void listofProduct()
        {
            dataGridView1.DataSource = CallProductsMethods.productList() ;
        }
        private void btnProdList_Click(object sender, EventArgs e)
        {
            listofProduct();
        }
        private void ProductsProcess_Load(object sender, EventArgs e)
        {
            comboBoxCatIdandName.Text = "SEÇİNİZ";
            comboBoxCatIdandName.DataSource = CallCategoryMethods.CategoryList();
            comboBoxCatIdandName.ValueMember = "CategoryId";
            comboBoxCatIdandName.DisplayMember = "CategoryName";

        }
        private void btnProdUpd_Click(object sender, EventArgs e)
        {
            products pro1 = new products();
            if (txtProdName.Text != "" && txtProdName.Text.Trim().Length > 0 && txtProdUnitPrice.Text != "" &&
                txtProdUnitPrice.Text.Trim().Length > 0) //catıd seçiliyse ekle
            {
                pro1.ProductName=txtProdName.Text.Trim();
                pro1.ProductUnitPrice = Convert.ToInt32(txtProdUnitPrice.Text);
                pro1.CategoryId = comboBoxCatIdandName.SelectedValue.ToString();
                pro1.ProductId=Convert.ToInt32(txtProdName.Tag);
                if (CallProductsMethods.UpdateProduct(pro1)<=0)
                {
                    MessageBox.Show("Güncelleme işlemi başarısız.");
                }
                else
                {
                    listofProduct();
                    clearAllBox();
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtProdName.Tag = row.Cells["ProductId"].Value.ToString();
            txtProdName.Text = row.Cells["ProductName"].Value.ToString();
            txtProdUnitPrice.Text= row.Cells["ProductUnitPrice"].Value.ToString();
            comboBoxCatIdandName.Tag = row.Cells["CategoryId"].Value.ToString();
            
            var sorgu = CallCategoryMethods.CategoryList().Find(p => p.CategoryID == row.Cells["CategoryId"].Value.ToString()).CategoryName.ToString(); //new info
            comboBoxCatIdandName.Text=sorgu.ToString();
        }
        private void clearAllBox()
        {
            txtProdName.Text = "";
            txtProdUnitPrice.Text = "";
        }
        private void btnProdDel_Click(object sender, EventArgs e)
        {
            products pro1 = new products();
            pro1.ProductId = Convert.ToInt32(txtProdName.Tag);
            if (CallProductsMethods.DelProduct(pro1)<1)
            {
                MessageBox.Show("Silme işlemi yapılamadı. Silinecek ürünn seçin");
            }
            else
            {
                listofProduct();clearAllBox(); 
            }
        }

        private void comboBoxCatIdandName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCatIdandName_Click(object sender, EventArgs e)
        {
          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeLoginandSignUp logOut = new EmployeeLoginandSignUp();
            logOut.Show();
            this.Hide();
        }
    }
}
