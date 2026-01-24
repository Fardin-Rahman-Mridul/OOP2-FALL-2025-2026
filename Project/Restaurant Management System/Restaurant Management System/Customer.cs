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
    public partial class Customer : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public Customer()
        {
            
            InitializeComponent();
            this.Da = new DataAccess();
            this.Ds = new DataSet();
            LoadMenuData();
            //SetupOrderSummaryGrid();
        }
        public Customer(string userid, string name)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.Ds = new DataSet();

            LoadMenuData();
            //SetupOrderSummaryGrid();

            txtCustomerID.Text = userid;
            txtCustomerName.Text = name;

            txtCustomerID.ReadOnly = true;
            txtCustomerName.ReadOnly = true;


           
        }

        

        private void LoadMenuData(string sql = "SELECT * FROM ManageMenu")
        {
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);
                dgvMenuCategories.AutoGenerateColumns = true;
                dgvMenuCategories.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menu: " + ex.Message);
            }
        }
        //private void SetupOrderSummaryGrid()
        //{
        //    dgvOrderSummary.Columns.Clear();
        //    dgvOrderSummary.Columns.Add("CustomerID", "CustomerID");
        //    dgvOrderSummary.Columns.Add("CustomerName", "CustomerName");
        //    dgvOrderSummary.Columns.Add("FoodID", "FoodID");
        //    dgvOrderSummary.Columns.Add("FoodName", "FoodName");
        //    dgvOrderSummary.Columns.Add("Quantity", "Quantity");
        //    dgvOrderSummary.Columns.Add("FoodPrice", "FoodPrice");
        //    dgvOrderSummary.Columns.Add("TotalPrice", "TotalPrice");
        //}


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtCustomerID.Text == "" || txtCustomerName.Text == "" ||
                txtFoodID.Text == "" || txtFoodName.Text == "" ||
                txtQuantity.Text == "" || txtFoodPrice.Text == "")
            {
                MessageBox.Show("Fill all fields before adding.");
                return;
            }

            using (SqlConnection con = new SqlConnection(
                @"Server=DESKTOP-SKDGCME\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();

                string checkSql = "SELECT COUNT(*) FROM Customer WHERE CustomerID=@CustomerID";
                SqlCommand cmdCheck = new SqlCommand(checkSql, con);
                cmdCheck.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);

                int exists = (int)cmdCheck.ExecuteScalar();

                string sql = "";

                if (exists == 0)
                {
                    sql = @"INSERT INTO Customer(CustomerID, CustomerName, FoodID, FoodName, Quantity, FoodPrice, TotalPrice)
                    VALUES(@CustomerID, @CustomerName, @FoodID, @FoodName, @Quantity, @FoodPrice, @TotalPrice)";
                }
                else
                {
                    sql = @"UPDATE Customer SET 
                        FoodID = @FoodID,
                        FoodName = @FoodName,
                        Quantity = @Quantity,
                        FoodPrice = @FoodPrice,
                        TotalPrice = @TotalPrice
                    WHERE CustomerID = @CustomerID";
                }

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
                cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@FoodID", txtFoodID.Text);
                cmd.Parameters.AddWithValue("@FoodName", txtFoodName.Text);
                cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@FoodPrice", txtFoodPrice.Text);
                cmd.Parameters.AddWithValue("@TotalPrice", txtTotalPrice.Text);

                cmd.ExecuteNonQuery();
            }

            LoadCustomerOrder();
            MessageBox.Show("Order Added Successfully!");

            ClearInput();
        }

        



        
        private void LoadCustomerOrder()
        {
           

            string sql = "SELECT * FROM Customer WHERE CustomerID='" + txtCustomerID.Text + "'";
            DataSet ds = this.Da.ExecuteQuery(sql);

            dgvOrderSummary.AutoGenerateColumns = true;
            dgvOrderSummary.DataSource = ds.Tables[0];

        }

        private void ClearInput()
        {
            txtFoodID.Clear();
            txtFoodName.Clear();
            txtQuantity.Clear();
            txtFoodPrice.Clear();
            txtTotalPrice.Clear();
        }


        private void dgvMenuCategories_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMenuCategories.CurrentRow != null)
            {
                txtFoodID.Text = dgvMenuCategories.CurrentRow.Cells["FoodID"].Value.ToString();
                txtFoodName.Text = dgvMenuCategories.CurrentRow.Cells["FoodName"].Value.ToString();
                txtFoodPrice.Text = dgvMenuCategories.CurrentRow.Cells["FoodPrice"].Value.ToString();
            }
        }

        private void dgvOrderSummary_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int qty) &&
               decimal.TryParse(txtFoodPrice.Text, out decimal price))
            {
                txtTotalPrice.Text = (qty * price).ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrderSummary.CurrentRow != null)
            {
                dgvOrderSummary.Rows.RemoveAt(dgvOrderSummary.CurrentRow.Index);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            Form1 f = new Form1();
            this.Hide();
            f.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dgvOrderSummary.CurrentRow == null)
            {
                MessageBox.Show("Select an item to update.");
                return;
            }

            // Quantity & Price recalc
            if (int.TryParse(txtQuantity.Text, out int qty) &&
                decimal.TryParse(txtFoodPrice.Text, out decimal price))
            {
                txtTotalPrice.Text = (qty * price).ToString();
            }
            else
            {
                MessageBox.Show("Invalid quantity or price.");
                return;
            }

            int rowIndex = dgvOrderSummary.CurrentRow.Index;

            dgvOrderSummary.Rows[rowIndex].Cells["CustomerID"].Value = txtCustomerID.Text;
            dgvOrderSummary.Rows[rowIndex].Cells["CustomerName"].Value = txtCustomerName.Text;
            dgvOrderSummary.Rows[rowIndex].Cells["FoodID"].Value = txtFoodID.Text;
            dgvOrderSummary.Rows[rowIndex].Cells["FoodName"].Value = txtFoodName.Text;
            dgvOrderSummary.Rows[rowIndex].Cells["Quantity"].Value = txtQuantity.Text;
            dgvOrderSummary.Rows[rowIndex].Cells["FoodPrice"].Value = txtFoodPrice.Text;
            dgvOrderSummary.Rows[rowIndex].Cells["TotalPrice"].Value = txtTotalPrice.Text;

            MessageBox.Show("Item updated successfully!");

            ClearInput();
        }

        private void txtSearchBy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cmbSearchBy.Text) || string.IsNullOrEmpty(this.txtSearch.Text))
            {
                LoadMenuData();
                return;
            }

            string sql = "SELECT * FROM ManageMenu WHERE [" + this.cmbSearchBy.Text + "] LIKE '" + this.txtSearch.Text + "%';";
            LoadMenuData(sql);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ManageMenu WHERE [" + this.cmbSearchBy.Text + "] LIKE '" + this.txtSearch.Text + "%';";
            LoadMenuData(sql);
        }

        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cmbSearchBy.Text) || string.IsNullOrEmpty(this.txtSearch.Text))
            {
                LoadMenuData();
                return;
            }

            string sql = "SELECT * FROM ManageMenu WHERE [" + this.cmbSearchBy.Text + "] LIKE '" + this.txtSearch.Text + "%';";

            LoadMenuData(sql);
        }
    }
}

