namespace Restaurant_Management_System
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            lblBillingAndPaymentPanel = new Label();
            dgvBillAndPaymentPanel = new DataGridView();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblSearchBy = new Label();
            btnGenerateBill = new Button();
            btnBack = new Button();
            cmbSearchBy = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvBillAndPaymentPanel).BeginInit();
            SuspendLayout();
            // 
            // lblBillingAndPaymentPanel
            // 
            lblBillingAndPaymentPanel.AutoSize = true;
            lblBillingAndPaymentPanel.BackColor = Color.Transparent;
            lblBillingAndPaymentPanel.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBillingAndPaymentPanel.Location = new Point(281, 20);
            lblBillingAndPaymentPanel.Name = "lblBillingAndPaymentPanel";
            lblBillingAndPaymentPanel.Size = new Size(434, 40);
            lblBillingAndPaymentPanel.TabIndex = 2;
            lblBillingAndPaymentPanel.Text = "Billing And Payment Panel";
            // 
            // dgvBillAndPaymentPanel
            // 
            dgvBillAndPaymentPanel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillAndPaymentPanel.Location = new Point(51, 83);
            dgvBillAndPaymentPanel.Name = "dgvBillAndPaymentPanel";
            dgvBillAndPaymentPanel.RowHeadersWidth = 62;
            dgvBillAndPaymentPanel.Size = new Size(850, 225);
            dgvBillAndPaymentPanel.TabIndex = 3;
            dgvBillAndPaymentPanel.DoubleClick += dgvBillAndPaymentPanel_DoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(51, 433);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(212, 31);
            txtSearch.TabIndex = 20;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.Black;
            lblSearch.Location = new Point(124, 407);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(72, 23);
            lblSearch.TabIndex = 19;
            lblSearch.Text = "Search";
            // 
            // lblSearchBy
            // 
            lblSearchBy.AutoSize = true;
            lblSearchBy.BackColor = Color.Transparent;
            lblSearchBy.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchBy.ForeColor = Color.Black;
            lblSearchBy.Location = new Point(106, 334);
            lblSearchBy.Name = "lblSearchBy";
            lblSearchBy.Size = new Size(100, 23);
            lblSearchBy.TabIndex = 18;
            lblSearchBy.Text = "Search By";
            // 
            // btnGenerateBill
            // 
            btnGenerateBill.BackColor = Color.Brown;
            btnGenerateBill.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateBill.ForeColor = Color.Transparent;
            btnGenerateBill.Location = new Point(700, 334);
            btnGenerateBill.Name = "btnGenerateBill";
            btnGenerateBill.Size = new Size(201, 55);
            btnGenerateBill.TabIndex = 22;
            btnGenerateBill.Text = "Generate Bill";
            btnGenerateBill.UseVisualStyleBackColor = false;
            btnGenerateBill.Click += btnGenerateBill_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.ForestGreen;
            btnBack.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(783, 433);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 55);
            btnBack.TabIndex = 25;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // cmbSearchBy
            // 
            cmbSearchBy.FormattingEnabled = true;
            cmbSearchBy.Items.AddRange(new object[] { "CustomerID", "CustomerName" });
            cmbSearchBy.Location = new Point(51, 360);
            cmbSearchBy.Name = "cmbSearchBy";
            cmbSearchBy.Size = new Size(212, 33);
            cmbSearchBy.TabIndex = 26;
            cmbSearchBy.SelectedIndexChanged += cmbSearchBy_SelectedIndexChanged;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(964, 494);
            Controls.Add(cmbSearchBy);
            Controls.Add(btnBack);
            Controls.Add(btnGenerateBill);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblSearchBy);
            Controls.Add(dgvBillAndPaymentPanel);
            Controls.Add(lblBillingAndPaymentPanel);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Staff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            Load += Staff_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBillAndPaymentPanel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBillingAndPaymentPanel;
        private DataGridView dgvBillAndPaymentPanel;
        private TextBox txtSearch;
        private Label lblSearch;
        private Label lblSearchBy;
        private Button btnGenerateBill;
        private Button btnBack;
        private ComboBox cmbSearchBy;
    }
}