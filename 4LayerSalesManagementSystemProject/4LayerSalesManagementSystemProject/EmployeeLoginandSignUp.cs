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
    public partial class EmployeeLoginandSignUp : Form
    {
        public static employees ActiveEmployee = new employees();
        public EmployeeLoginandSignUp()
        {
            InitializeComponent();
        }
        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblNameSurname.Visible = true;
            btnSign.Visible = true;
            txtNameSurname.Visible = true;
            linkLabelSignUp.Visible = false;
            linkLabelLogin.Visible = true ;
            label4SignUpTitle.Visible = true;
            label3LoginTitle.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            employees emp1 = new employees();
            if (txtuserName.Text!="" && txtuserName.Text.Trim().Length>0 && txtPassword.Text!="" && txtPassword.Text.Trim().Length>0)
            {
                emp1.EmployeeUserName = txtuserName.Text.Trim();
                emp1.EmployeePassword= txtPassword.Text.Trim();
                
                if (CallEmployeeMethods.CallEmployeeLogin(emp1))
                {
                    Dashboard dash=new Dashboard();
                    ActiveEmployee.EmployeeUserName=emp1.EmployeeUserName;
                    ActiveEmployee.EmployeePassword=emp1.EmployeePassword;
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı. Tekrar deneyiniz.");
                }
            }else
            {
                MessageBox.Show("Eksik veya hatalı giriş yaptınız. Tekrar Deneyiniz.");
            }
            txtPassword.Text = "";
            txtuserName.Text = "";
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnLogin.Visible = true;
            btnSign.Visible = false;
            lblNameSurname.Visible = false;
            txtNameSurname.Visible= false;
            linkLabelSignUp.Visible = true;
            linkLabelLogin.Visible = false;
            label3LoginTitle.Visible = true;
            label4SignUpTitle.Visible = false;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            employees emp1 = new employees();
            if (txtNameSurname.Text != "" && txtNameSurname.Text.Trim().Length > 0 && txtuserName.Text != "" && txtuserName.Text.Trim().Length > 0 && txtPassword.Text != "" && txtPassword.Text.Trim().Length > 0)
            {
                if (!CallEmployeeMethods.EmployeeList().Any(p => p.EmployeeUserName == txtuserName.Text))
                {

                    emp1.EmployeeNameSurname = txtNameSurname.Text.Trim();
                    emp1.EmployeeUserName = txtuserName.Text.Trim();
                    emp1.EmployeePassword = txtPassword.Text.Trim();
                    if (CallEmployeeMethods.AddEmployee(emp1))
                    {
                        MessageBox.Show("Employee kaydı gerçekleşti. Artık bu hesaptan giriş yapılabilir.");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt sırasında bir hatayla karşılaşıldı. Daha sonra tekrar deneyiniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Bu kullanıcı adı alınmış. Başka bir username seçiniz.");
                }
            }
            else
            {
                MessageBox.Show("Eksik yada hatalı giriş yaptınız.");
            }
            txtNameSurname.Text ="";
            txtPassword.Text = "";
            txtuserName.Text = "";
        }  
    }
}
