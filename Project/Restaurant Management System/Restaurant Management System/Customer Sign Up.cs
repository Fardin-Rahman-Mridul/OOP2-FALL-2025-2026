using Microsoft.Data.SqlClient;
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
    public partial class Customer_Sign_Up : Form
    {
        public Customer_Sign_Up()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

            string name = txtCustomerName.Text;
            string userid = txtUserID.Text;
            string password = txtPassword.Text;
            string role = "Customer"; // auto role

            if (name == "" || userid == "" || password == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            try
            {
                 string cs = @"Server=DESKTOP-SKDGCME\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    string query = "INSERT INTO ManageUsers (Name, Password, Role, UserID) VALUES (@Name, @Password, @Role, @UserID)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@UserID", userid);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Signup Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Signup Failed!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}

