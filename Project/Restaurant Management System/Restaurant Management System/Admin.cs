using Microsoft.VisualBasic.Logging;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btnManageMenu_Click(object sender, EventArgs e)
        {
            Manage_Menu menuForm = new Manage_Menu();
            menuForm.Show();
            this.Hide();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            Manage_Users usersForm = new Manage_Users();
            usersForm.Show();
            this.Hide();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            Sales_Report reportForm = new Sales_Report();
            reportForm.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
