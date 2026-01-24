namespace Restaurant_Management_System
{
    partial class Sales_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Report));
            dgvSalesReport = new DataGridView();
            label1 = new Label();
            lblTotalSales = new Label();
            txtTotalSales = new TextBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).BeginInit();
            SuspendLayout();
            // 
            // dgvSalesReport
            // 
            dgvSalesReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesReport.Location = new Point(528, 115);
            dgvSalesReport.Name = "dgvSalesReport";
            dgvSalesReport.RowHeadersWidth = 62;
            dgvSalesReport.Size = new Size(472, 248);
            dgvSalesReport.TabIndex = 0;
            dgvSalesReport.DoubleClick += dgvSalesReport_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(398, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 40);
            label1.TabIndex = 35;
            label1.Text = "Sales Report";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.BackColor = Color.Transparent;
            lblTotalSales.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSales.ForeColor = Color.Black;
            lblTotalSales.Location = new Point(561, 391);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(129, 28);
            lblTotalSales.TabIndex = 36;
            lblTotalSales.Text = "Total Sales";
            // 
            // txtTotalSales
            // 
            txtTotalSales.Location = new Point(736, 391);
            txtTotalSales.Name = "txtTotalSales";
            txtTotalSales.Size = new Size(239, 31);
            txtTotalSales.TabIndex = 37;
            txtTotalSales.TextChanged += txtTotalSales_TextChanged;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.ForestGreen;
            btnBack.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(882, 450);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 55);
            btnBack.TabIndex = 38;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Sales_Report
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1012, 506);
            Controls.Add(btnBack);
            Controls.Add(txtTotalSales);
            Controls.Add(lblTotalSales);
            Controls.Add(label1);
            Controls.Add(dgvSalesReport);
            DoubleBuffered = true;
            Name = "Sales_Report";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales_Report";
            Load += Sales_Report_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSalesReport;
        private Label label1;
        private Label lblTotalSales;
        private TextBox txtTotalSales;
        private Button btnBack;
    }
}