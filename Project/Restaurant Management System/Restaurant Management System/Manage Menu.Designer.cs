namespace Restaurant_Management_System
{
    partial class Manage_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Menu));
            label1 = new Label();
            lblFoodID = new Label();
            lblFoodName = new Label();
            lblCategory = new Label();
            lblFoodPrice = new Label();
            txtFoodID = new TextBox();
            txtFoodName = new TextBox();
            txtCategory = new TextBox();
            txtFoodPrice = new TextBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblSearchBy = new Label();
            btnBack = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dgvManageMenu = new DataGridView();
            cmbSearchBy = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvManageMenu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 27);
            label1.Name = "label1";
            label1.Size = new Size(233, 40);
            label1.TabIndex = 1;
            label1.Text = "Manage Menu";
            // 
            // lblFoodID
            // 
            lblFoodID.AutoSize = true;
            lblFoodID.BackColor = Color.Transparent;
            lblFoodID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodID.ForeColor = Color.Black;
            lblFoodID.Location = new Point(34, 100);
            lblFoodID.Name = "lblFoodID";
            lblFoodID.Size = new Size(91, 28);
            lblFoodID.TabIndex = 3;
            lblFoodID.Text = "FoodID";
            // 
            // lblFoodName
            // 
            lblFoodName.AutoSize = true;
            lblFoodName.BackColor = Color.Transparent;
            lblFoodName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodName.ForeColor = Color.Black;
            lblFoodName.Location = new Point(34, 160);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(129, 28);
            lblFoodName.TabIndex = 4;
            lblFoodName.Text = "FoodName";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.Black;
            lblCategory.Location = new Point(34, 216);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(111, 28);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // lblFoodPrice
            // 
            lblFoodPrice.AutoSize = true;
            lblFoodPrice.BackColor = Color.Transparent;
            lblFoodPrice.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodPrice.ForeColor = Color.Black;
            lblFoodPrice.Location = new Point(34, 272);
            lblFoodPrice.Name = "lblFoodPrice";
            lblFoodPrice.Size = new Size(124, 28);
            lblFoodPrice.TabIndex = 6;
            lblFoodPrice.Text = "FoodPrice";
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new Point(193, 100);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.Size = new Size(336, 31);
            txtFoodID.TabIndex = 7;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(193, 160);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(336, 31);
            txtFoodName.TabIndex = 8;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(193, 216);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(336, 31);
            txtCategory.TabIndex = 9;
            // 
            // txtFoodPrice
            // 
            txtFoodPrice.Location = new Point(193, 272);
            txtFoodPrice.Name = "txtFoodPrice";
            txtFoodPrice.Size = new Size(336, 31);
            txtFoodPrice.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(630, 200);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(212, 31);
            txtSearch.TabIndex = 16;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.Black;
            lblSearch.Location = new Point(703, 174);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(72, 23);
            lblSearch.TabIndex = 15;
            lblSearch.Text = "Search";
            // 
            // lblSearchBy
            // 
            lblSearchBy.AutoSize = true;
            lblSearchBy.BackColor = Color.Transparent;
            lblSearchBy.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchBy.ForeColor = Color.Black;
            lblSearchBy.Location = new Point(685, 101);
            lblSearchBy.Name = "lblSearchBy";
            lblSearchBy.Size = new Size(100, 23);
            lblSearchBy.TabIndex = 14;
            lblSearchBy.Text = "Search By";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.ForestGreen;
            btnBack.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(695, 335);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 55);
            btnBack.TabIndex = 24;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SlateGray;
            btnClear.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Transparent;
            btnClear.Location = new Point(539, 335);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 55);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Transparent;
            btnUpdate.Location = new Point(230, 335);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 55);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(385, 335);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 55);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RoyalBlue;
            btnAdd.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Transparent;
            btnAdd.Location = new Point(83, 335);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 55);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvManageMenu
            // 
            dgvManageMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManageMenu.Location = new Point(34, 420);
            dgvManageMenu.Name = "dgvManageMenu";
            dgvManageMenu.RowHeadersWidth = 62;
            dgvManageMenu.Size = new Size(808, 211);
            dgvManageMenu.TabIndex = 25;
            dgvManageMenu.DoubleClick += dgvManageMenu_DoubleClick;
            // 
            // cmbSearchBy
            // 
            cmbSearchBy.FormattingEnabled = true;
            cmbSearchBy.Items.AddRange(new object[] { "FoodID", "FoodName", "Category" });
            cmbSearchBy.Location = new Point(630, 138);
            cmbSearchBy.Name = "cmbSearchBy";
            cmbSearchBy.Size = new Size(212, 33);
            cmbSearchBy.TabIndex = 26;
            cmbSearchBy.SelectedIndexChanged += cmbSearchBy_SelectedIndexChanged;
            // 
            // Manage_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(882, 643);
            Controls.Add(cmbSearchBy);
            Controls.Add(dgvManageMenu);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblSearchBy);
            Controls.Add(txtFoodPrice);
            Controls.Add(txtCategory);
            Controls.Add(txtFoodName);
            Controls.Add(txtFoodID);
            Controls.Add(lblFoodPrice);
            Controls.Add(lblCategory);
            Controls.Add(lblFoodName);
            Controls.Add(lblFoodID);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Manage_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage_Menu";
            ((System.ComponentModel.ISupportInitialize)dgvManageMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblFoodID;
        private Label lblFoodName;
        private Label lblCategory;
        private Label lblFoodPrice;
        private TextBox txtFoodID;
        private TextBox txtFoodName;
        private TextBox txtCategory;
        private TextBox txtFoodPrice;
        private TextBox txtSearchBy;
        private TextBox txtSearch;
        private Label lblSearch;
        private Label lblSearchBy;
        private Button btnBack;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvManageMenu;
        private ComboBox cmbSearchBy;
    }
}