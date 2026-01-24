using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class Staff : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        //print
        private PrintDocument printDoc = new PrintDocument();
        private string printBillText = "";

        // Store selected row data
        private string selectedCustomerID = "";
        private string selectedCustomerName = "";
        private string selectedFoodName = "";
        private string selectedTotalPrice = "";
        public Staff()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            LoadCustomerData();
            printDoc.PrintPage += PrintDoc_PrintPage;
        }
        private void LoadCustomerData(string sql = "SELECT * FROM Customer")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            dgvBillAndPaymentPanel.AutoGenerateColumns = true;
            dgvBillAndPaymentPanel.DataSource = this.Ds.Tables[0];
        }
        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printBillText, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }

        private void dgvBillAndPaymentPanel_DoubleClick(object sender, EventArgs e)
        {
            if (dgvBillAndPaymentPanel.CurrentRow != null)
            {
                selectedCustomerID = dgvBillAndPaymentPanel.CurrentRow.Cells["CustomerID"].Value?.ToString();
                selectedCustomerName = dgvBillAndPaymentPanel.CurrentRow.Cells["CustomerName"].Value?.ToString();
                selectedFoodName = dgvBillAndPaymentPanel.CurrentRow.Cells["FoodName"].Value?.ToString();
                selectedTotalPrice = dgvBillAndPaymentPanel.CurrentRow.Cells["TotalPrice"].Value?.ToString();

                MessageBox.Show($"Selected: {selectedCustomerID}, {selectedCustomerName}", "Info");
            }
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedCustomerID))
            {
                MessageBox.Show("Select a customer row first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            printBillText =
                "******** RESTAURANT BILL ********\n\n" +
                "Customer ID : " + selectedCustomerID + "\n" +
                "Name        : " + selectedCustomerName + "\n" +
                "Item        : " + selectedFoodName + "\n" +
                "Total Price : " + selectedTotalPrice + " Taka\n" +
                "Date        : " + DateTime.Now.ToString("dd-MM-yyyy hh:mm tt") + "\n\n" +
                "--------------------------------\n" +
                "Thank You! Please Visit Again.\n";

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDoc;
            preview.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

        private void txtSearchBy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbSearchBy.Text) || string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadCustomerData();
                return;
            }

            string sql = $"SELECT * FROM Customer WHERE [{cmbSearchBy.Text}] LIKE '{txtSearch.Text}%'";
            LoadCustomerData(sql);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cmbSearchBy.Text)) return;

            string sql = $"SELECT * FROM Customer WHERE [{cmbSearchBy.Text}] LIKE '{txtSearch.Text}%'";
            LoadCustomerData(sql);

        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cmbSearchBy.Text) || string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadCustomerData();
                return;
            }

            string sql = $"SELECT * FROM Customer WHERE [{cmbSearchBy.Text}] LIKE '{txtSearch.Text}%'";
            LoadCustomerData(sql);

        }
    }
}
