using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Restaurant_Management_System
{
    public partial class Manage_Users : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public Manage_Users()
        {
            InitializeComponent();
            //this.Da = new DataAccess();
            this.Da = new DataAccess();
            this.Ds = new DataSet();
            PopulateGridView();
        }
        private void PopulateGridView(string sql = "SELECT * FROM ManageUsers")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvManageUsers.AutoGenerateColumns = true;
            this.dgvManageUsers.DataSource = this.Ds.Tables[0];
        }
        private void ClearAll()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtRole.Clear();
            txtUserID.Clear();
            txtSearch.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string role = txtRole.Text.Trim();
            string uid = txtUserID.Text.Trim();

            string sql = $"INSERT INTO ManageUsers(Name, Password, Role, UserID) " +
                         $"VALUES('{name}', '{pass}', '{role}', '{uid}')";

            int count = this.Da.ExecuteUpdateQuery(sql);

            if (count > 0)
            {
                MessageBox.Show("User Added!");
                PopulateGridView();
                ClearAll();
            }
        }


        private void dgvManageUsers_DoubleClick(object sender, EventArgs e)
        {
            if (dgvManageUsers.CurrentRow != null)
            {
                txtName.Text = dgvManageUsers.CurrentRow.Cells["Name"].Value.ToString();
                txtPassword.Text = dgvManageUsers.CurrentRow.Cells["Password"].Value.ToString();
                txtRole.Text = dgvManageUsers.CurrentRow.Cells["Role"].Value.ToString();
                txtUserID.Text = dgvManageUsers.CurrentRow.Cells["UserID"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string role = txtRole.Text.Trim();
            string uid = txtUserID.Text.Trim();

            string sql = $"UPDATE ManageUsers SET Password='{pass}', Role='{role}' WHERE UserID='{uid}'";

            int count = this.Da.ExecuteUpdateQuery(sql);

            if (count > 0)
            {
                MessageBox.Show("User Updated!");
                PopulateGridView();
                ClearAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uid = txtUserID.Text.Trim();

            string sql = $"DELETE FROM ManageUsers WHERE UserID='{uid}'";

            int count = this.Da.ExecuteUpdateQuery(sql);

            if (count > 0)
            {
                MessageBox.Show("User Deleted!");
                PopulateGridView();
                ClearAll();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin();
            this.Hide();
            adminForm.Show();
        }

        private void txtSearchBy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cmbSearchBy.Text) || string.IsNullOrEmpty(this.txtSearch.Text))
            {
                PopulateGridView();
                return;
            }

            string sql = $"SELECT * FROM ManageUsers WHERE [{this.cmbSearchBy.Text}] LIKE '{this.txtSearch.Text}%'";
            PopulateGridView(sql);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from ManageUsers where [" + this.cmbSearchBy.Text + "] like '" + this.txtSearch.Text + "%';"; PopulateGridView(sql);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cmbSearchBy.Text) || string.IsNullOrEmpty(this.txtSearch.Text))
            {
                PopulateGridView();
                return;
            }

            string sql = $"SELECT * FROM ManageUsers WHERE [{this.cmbSearchBy.Text}] LIKE '{this.txtSearch.Text}%'";
            PopulateGridView(sql);
        }
    }
}
