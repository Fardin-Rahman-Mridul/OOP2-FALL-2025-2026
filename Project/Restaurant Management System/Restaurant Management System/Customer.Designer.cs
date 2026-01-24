namespace Restaurant_Management_System
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblSearchBy = new Label();
            txtFoodPrice = new TextBox();
            txtQuantity = new TextBox();
            txtFoodName = new TextBox();
            txtFoodID = new TextBox();
            lblFoodPrice = new Label();
            lblQuantity = new Label();
            lblFoodName = new Label();
            lblFoodID = new Label();
            txtCustomerName = new TextBox();
            txtCustomerID = new TextBox();
            lblCustomerName = new Label();
            lblCustomerID = new Label();
            label1 = new Label();
            dgvMenuCategories = new DataGridView();
            txtTotalPrice = new TextBox();
            lblTotalPrice = new Label();
            btnBack = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dgvOrderSummary = new DataGridView();
            lblMenuCategories = new Label();
            lblOrderSummary = new Label();
            cmbSearchBy = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMenuCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderSummary).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(454, 329);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(187, 31);
            txtSearch.TabIndex = 28;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.Black;
            lblSearch.Location = new Point(361, 337);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(72, 23);
            lblSearch.TabIndex = 27;
            lblSearch.Text = "Search";
            // 
            // lblSearchBy
            // 
            lblSearchBy.AutoSize = true;
            lblSearchBy.BackColor = Color.Transparent;
            lblSearchBy.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchBy.ForeColor = Color.Black;
            lblSearchBy.Location = new Point(18, 337);
            lblSearchBy.Name = "lblSearchBy";
            lblSearchBy.Size = new Size(100, 23);
            lblSearchBy.TabIndex = 26;
            lblSearchBy.Text = "Search By";
            // 
            // txtFoodPrice
            // 
            txtFoodPrice.Location = new Point(802, 95);
            txtFoodPrice.Name = "txtFoodPrice";
            txtFoodPrice.Size = new Size(187, 31);
            txtFoodPrice.TabIndex = 25;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(802, 152);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(187, 31);
            txtQuantity.TabIndex = 24;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(255, 265);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(353, 31);
            txtFoodName.TabIndex = 23;
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new Point(255, 205);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.Size = new Size(353, 31);
            txtFoodID.TabIndex = 22;
            // 
            // lblFoodPrice
            // 
            lblFoodPrice.AutoSize = true;
            lblFoodPrice.BackColor = Color.Transparent;
            lblFoodPrice.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodPrice.ForeColor = Color.Black;
            lblFoodPrice.Location = new Point(639, 95);
            lblFoodPrice.Name = "lblFoodPrice";
            lblFoodPrice.Size = new Size(124, 28);
            lblFoodPrice.TabIndex = 21;
            lblFoodPrice.Text = "FoodPrice";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.Black;
            lblQuantity.Location = new Point(639, 152);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(109, 28);
            lblQuantity.TabIndex = 20;
            lblQuantity.Text = "Quantity";
            // 
            // lblFoodName
            // 
            lblFoodName.AutoSize = true;
            lblFoodName.BackColor = Color.Transparent;
            lblFoodName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodName.ForeColor = Color.Black;
            lblFoodName.Location = new Point(40, 265);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(129, 28);
            lblFoodName.TabIndex = 19;
            lblFoodName.Text = "FoodName";
            // 
            // lblFoodID
            // 
            lblFoodID.AutoSize = true;
            lblFoodID.BackColor = Color.Transparent;
            lblFoodID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodID.ForeColor = Color.Black;
            lblFoodID.Location = new Point(40, 205);
            lblFoodID.Name = "lblFoodID";
            lblFoodID.Size = new Size(91, 28);
            lblFoodID.TabIndex = 18;
            lblFoodID.Text = "FoodID";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(255, 155);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(353, 31);
            txtCustomerName.TabIndex = 33;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(255, 95);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(353, 31);
            txtCustomerID.TabIndex = 32;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.BackColor = Color.Transparent;
            lblCustomerName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.ForeColor = Color.Black;
            lblCustomerName.Location = new Point(40, 155);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(182, 28);
            lblCustomerName.TabIndex = 31;
            lblCustomerName.Text = "CustomerName";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.BackColor = Color.Transparent;
            lblCustomerID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerID.ForeColor = Color.Black;
            lblCustomerID.Location = new Point(40, 95);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(144, 28);
            lblCustomerID.TabIndex = 30;
            lblCustomerID.Text = "CustomerID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(462, 28);
            label1.Name = "label1";
            label1.Size = new Size(370, 40);
            label1.TabIndex = 34;
            label1.Text = "Customer Order Panel";
            // 
            // dgvMenuCategories
            // 
            dgvMenuCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenuCategories.Location = new Point(31, 425);
            dgvMenuCategories.Name = "dgvMenuCategories";
            dgvMenuCategories.RowHeadersWidth = 62;
            dgvMenuCategories.Size = new Size(586, 217);
            dgvMenuCategories.TabIndex = 35;
            dgvMenuCategories.DoubleClick += dgvMenuCategories_DoubleClick;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(802, 205);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(187, 31);
            txtTotalPrice.TabIndex = 37;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = Color.Transparent;
            lblTotalPrice.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.Black;
            lblTotalPrice.Location = new Point(639, 205);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(126, 28);
            lblTotalPrice.TabIndex = 36;
            lblTotalPrice.Text = "TotalPrice";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.ForestGreen;
            btnBack.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(1067, 167);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 55);
            btnBack.TabIndex = 42;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SlateGray;
            btnClear.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Transparent;
            btnClear.Location = new Point(1067, 106);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 55);
            btnClear.TabIndex = 41;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(934, 286);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 55);
            btnDelete.TabIndex = 39;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RoyalBlue;
            btnAdd.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Transparent;
            btnAdd.Location = new Point(757, 286);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 55);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvOrderSummary
            // 
            dgvOrderSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderSummary.Location = new Point(659, 425);
            dgvOrderSummary.Name = "dgvOrderSummary";
            dgvOrderSummary.RowHeadersWidth = 62;
            dgvOrderSummary.Size = new Size(551, 217);
            dgvOrderSummary.TabIndex = 43;
            dgvOrderSummary.DoubleClick += dgvOrderSummary_DoubleClick;
            // 
            // lblMenuCategories
            // 
            lblMenuCategories.AutoSize = true;
            lblMenuCategories.BackColor = Color.Transparent;
            lblMenuCategories.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuCategories.ForeColor = Color.Black;
            lblMenuCategories.Location = new Point(229, 391);
            lblMenuCategories.Name = "lblMenuCategories";
            lblMenuCategories.Size = new Size(196, 28);
            lblMenuCategories.TabIndex = 44;
            lblMenuCategories.Text = "Menu Categories";
            // 
            // lblOrderSummary
            // 
            lblOrderSummary.AutoSize = true;
            lblOrderSummary.BackColor = Color.Transparent;
            lblOrderSummary.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderSummary.ForeColor = Color.Black;
            lblOrderSummary.Location = new Point(834, 391);
            lblOrderSummary.Name = "lblOrderSummary";
            lblOrderSummary.Size = new Size(188, 28);
            lblOrderSummary.TabIndex = 45;
            lblOrderSummary.Text = "Order Summary";
            // 
            // cmbSearchBy
            // 
            cmbSearchBy.FormattingEnabled = true;
            cmbSearchBy.Items.AddRange(new object[] { "FoodID", "FoodName" });
            cmbSearchBy.Location = new Point(149, 333);
            cmbSearchBy.Name = "cmbSearchBy";
            cmbSearchBy.Size = new Size(182, 33);
            cmbSearchBy.TabIndex = 46;
            cmbSearchBy.SelectedIndexChanged += cmbSearchBy_SelectedIndexChanged;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1236, 644);
            Controls.Add(cmbSearchBy);
            Controls.Add(lblOrderSummary);
            Controls.Add(lblMenuCategories);
            Controls.Add(dgvOrderSummary);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtTotalPrice);
            Controls.Add(lblTotalPrice);
            Controls.Add(dgvMenuCategories);
            Controls.Add(label1);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerID);
            Controls.Add(lblCustomerName);
            Controls.Add(lblCustomerID);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblSearchBy);
            Controls.Add(txtFoodPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtFoodName);
            Controls.Add(txtFoodID);
            Controls.Add(lblFoodPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblFoodName);
            Controls.Add(lblFoodID);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)dgvMenuCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderSummary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearch;
        private Label lblSearch;
        private Label lblSearchBy;
        private TextBox txtFoodPrice;
        private TextBox txtQuantity;
        private TextBox txtFoodName;
        private TextBox txtFoodID;
        private Label lblFoodPrice;
        private Label lblQuantity;
        private Label lblFoodName;
        private Label lblFoodID;
        private TextBox txtCustomerName;
        private TextBox txtCustomerID;
        private Label lblCustomerName;
        private Label lblCustomerID;
        private Label label1;
        private DataGridView dgvMenuCategories;
        private TextBox txtTotalPrice;
        private Label lblTotalPrice;
        private Button btnBack;
        private Button btnClear;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvOrderSummary;
        private Label lblMenuCategories;
        private Label lblOrderSummary;
        private ComboBox cmbSearchBy;
    }
}