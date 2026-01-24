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
    public partial class Sales_Report : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public Sales_Report()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            LoadSalesData();
        }
        private void LoadSalesData(string sql = "SELECT * FROM Customer")
        {
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgvSalesReport.AutoGenerateColumns = true;
                this.dgvSalesReport.DataSource = this.Ds.Tables[0];

                CalculateTotalSales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales data: " + ex.Message);
            }
        }
        private void CalculateTotalSales()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvSalesReport.Rows)
            {
                try
                {
                    if (row.Cells["TotalPrice"].Value != null)
                    {
                        decimal price = 0;
                        decimal.TryParse(row.Cells["TotalPrice"].Value.ToString(), out price);
                        total += price;
                    }
                }
                catch { }
            }

            txtTotalSales.Text = total.ToString();
        }

        private void Sales_Report_Load(object sender, EventArgs e)
        {

        }

        private void dgvSalesReport_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.Show();
        }

        private void txtTotalSales_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
