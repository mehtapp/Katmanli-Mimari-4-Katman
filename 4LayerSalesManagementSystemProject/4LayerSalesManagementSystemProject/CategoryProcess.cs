using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Facade;
using BusinessORM;

namespace MVC4LayerSalesManagementSystemProject
{
    public partial class CategoryProcess : Form
    {
        public CategoryProcess()
        {
            InitializeComponent();
        }

        public void categoryList()
        {
            dataGridView1.DataSource = CallCategoryMethods.CategoryList();
        }
        private void CategoryProcess_Load(object sender, EventArgs e)
        { 
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsProcess productPage= new ProductsProcess();
            productPage.Show();
            this.Hide();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerProcess customerPage= new CustomerProcess();
            customerPage.Show();
            this.Hide();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryProcess categoryPage= new CategoryProcess();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeLoginandSignUp logOut = new EmployeeLoginandSignUp();
            logOut.Show();
            this.Hide();
        }

        private void btnCatList_Click(object sender, EventArgs e)
        {
            categoryList();
        }

        private void btnCatAdd_Click(object sender, EventArgs e)
        {
            
            categories cat1= new categories();

            if (txtCategoryName.Text != "" && txtCategoryName.Text.Trim().Length > 0)
            {
                cat1.CategoryName = txtCategoryName.Text.Trim();
                if (CallCategoryMethods.AddCategory(cat1))
                {
                    clearAllBox();
                }
                else
                {
                    MessageBox.Show("Kategori Ekleme İşlemi Başarısız. "+Environment.NewLine +"Dikkat"+Environment.NewLine +"Aynı isimde yeni bir kategori eklemeyiniz.","Dikkat",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                categoryList();
            }
            else
            {
                MessageBox.Show("Category adı alanı boş geçilemez. Bu şekilde Ekleme işlemi yapamazsınız.");
            }
               
        }

        private void btnCatUpd_Click(object sender, EventArgs e)
        {
            categories category1 = new categories();
            if (txtCategoryName.Text!="" && txtCategoryName.Text.Trim().Length>0) //trim boilukları atar. Böylece kutuda kalan metin
                                                                                  //uzunluğu var mı diye bakar yoksa boştur kaydetmez. 
            {
                category1.CategoryName = txtCategoryName.Text.Trim();
                category1.CategoryID = Convert.ToString(txtCategoryName.Tag);
                if (!CallCategoryMethods.UpdCategory(category1))
                { 
                    MessageBox.Show("Güncelleme Başarısız.");
                }
                else { clearAllBox(); }
                
            }
            else
                MessageBox.Show("Category adı alanı boş geçilemez. Bu şekilde güncelleme işlemi yapamazsınız.");

            categoryList();
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtCategoryName.Tag = row.Cells["CategoryId"].Value;
           txtCategoryName.Text = row.Cells["CategoryName"].Value.ToString();
        }

        private void btnCatDel_Click(object sender, EventArgs e)
        {
            categories cat1 = new categories();
            cat1.CategoryID = txtCategoryName.Tag.ToString();
            if (!CallCategoryMethods.DelCategory(cat1))
            {
                MessageBox.Show("Silme işlemi başarısız");
            }
            else
            {
                clearAllBox();
            }
            categoryList();



        }
        public void clearAllBox()
        {
            txtCategoryName.Clear();
        }
        
    }
}
