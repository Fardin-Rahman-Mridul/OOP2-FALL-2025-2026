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
    public partial class Manage_Menu : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public Manage_Menu()
        {
            InitializeComponent();
            //this.Da = new DataAccess();
            this.Da = new DataAccess();
            this.Ds = new DataSet();
            PopulateGridView();
        }
        private void PopulateGridView(string sql = "SELECT * FROM ManageMenu")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvManageMenu.AutoGenerateColumns = true;
            this.dgvManageMenu.DataSource = this.Ds.Tables[0];
        }

        private void ClearAll()
        {
            txtFoodID.Clear();
            txtFoodName.Clear();
            txtCategory.Clear();
            txtFoodPrice.Clear();
            txtSearch.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtFoodName.Text.Trim();
            string category = txtCategory.Text.Trim();
            string price = txtFoodPrice.Text.Trim();

            string sql = @"INSERT INTO ManageMenu (FoodID, FoodName, Category, FoodPrice)
               VALUES ('" + txtFoodID.Text + "', '" + txtFoodName.Text + "', '" + txtCategory.Text + "', '" + txtFoodPrice.Text + "')";


            int count = this.Da.ExecuteUpdateQuery(sql);

            if (count > 0)
            {
                MessageBox.Show("Food Added!");
                PopulateGridView();
                ClearAll();
            }
        }


        private void dgvManageMenu_DoubleClick(object sender, EventArgs e)
        {
            if (dgvManageMenu.CurrentRow != null)
            {
                txtFoodID.Text = dgvManageMenu.CurrentRow.Cells["FoodID"].Value.ToString();
                txtFoodName.Text = dgvManageMenu.CurrentRow.Cells["FoodName"].Value.ToString();
                txtCategory.Text = dgvManageMenu.CurrentRow.Cells["Category"].Value.ToString();
                txtFoodPrice.Text = dgvManageMenu.CurrentRow.Cells["FoodPrice"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtFoodID.Text.Trim();
            string name = txtFoodName.Text.Trim();
            string category = txtCategory.Text.Trim();
            string price = txtFoodPrice.Text.Trim();

            string sql = $"UPDATE ManageMenu SET FoodName='{name}', Category='{category}', FoodPrice='{price}' WHERE FoodID='{id}'";

            int count = this.Da.ExecuteUpdateQuery(sql);

            if (count > 0)
            {
                MessageBox.Show("Food Updated!");
                PopulateGridView();
                ClearAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtFoodID.Text.Trim();

            string sql = $"DELETE FROM ManageMenu WHERE FoodID='{id}'";
            int count = this.Da.ExecuteUpdateQuery(sql);

            if (count > 0)
            {
                MessageBox.Show("Food Deleted!");
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
            if (string.IsNullOrEmpty(this.txtSearchBy.Text) || string.IsNullOrEmpty(this.txtSearch.Text))
            {
                PopulateGridView();
                return;
            }

            string sql = $"SELECT * FROM ManageMenu WHERE [{this.txtSearchBy.Text}] LIKE '{this.txtSearch.Text}%'";
            PopulateGridView(sql);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from ManageMenu where [" + this.cmbSearchBy.Text + "] like '" + this.txtSearch.Text + "%';";
            PopulateGridView(sql);
        }

        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cmbSearchBy.Text) || string.IsNullOrEmpty(this.txtSearch.Text))
            {
                PopulateGridView();
                return;
            }

            string sql = $"SELECT * FROM ManageMenu WHERE [{this.cmbSearchBy.Text}] LIKE '{this.txtSearch.Text}%'";
            PopulateGridView(sql);

            //if (string.IsNullOrEmpty(this.cmbSearchBy.Text) || string.IsNullOrEmpty(this.txtSearch.Text)) { LoadMenuData(); return; }
            //string sql = "SELECT * FROM ManageMenu WHERE [" + this.cmbSearchBy.Text + "] LIKE '" + this.txtSearch.Text + "%';"; LoadMenuData(sql);
        }
    }
}
