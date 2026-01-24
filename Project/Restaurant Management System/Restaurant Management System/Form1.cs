using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class Form1 : Form
    {
        DataAccess Da = new DataAccess();
        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                string user = txtUserID.Text.Trim();
                string pass = txtPassword.Text.Trim();

                string query = $"SELECT * FROM ManageUsers WHERE UserID = '{user}' AND Password = '{pass}'";
                var dt = Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    string role = dt.Rows[0]["Role"].ToString();
                    string userid = dt.Rows[0]["UserID"].ToString();
                    string name = dt.Rows[0]["Name"].ToString();

                    if (role == "Admin")
                    {
                        Admin adminForm = new Admin();
                        adminForm.Show();
                        this.Hide();

                    }
                    else if (role == "Customer")
                    {
                        Customer customerForm = new Customer(userid, name);
                        customerForm.Show();
                        this.Hide();
                    }
                    else if (role == "Staff")
                    {
                        Staff staffForm = new Staff();
                        staffForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User ID or Password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Clear()
        {
            this.txtUserID.Text = "";
            this.txtPassword.Text = "";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkShowPassword.Checked)
            //{
            //    txtPassword.UseSystemPasswordChar = false; // show password
            //}
            //else
            //{
            //    txtPassword.UseSystemPasswordChar = true;  // hide password
            //}

            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnCustomerSignUp_Click(object sender, EventArgs e)
        {
            Customer_Sign_Up cs = new Customer_Sign_Up();
            cs.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

