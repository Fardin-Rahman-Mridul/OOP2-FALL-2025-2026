namespace Restaurant_Management_System
{
    partial class Manage_Users
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
            label1 = new Label();
            lblName = new Label();
            lblPassword = new Label();
            lblRole = new Label();
            lblUserID = new Label();
            lblSearchBy = new Label();
            lblSearch = new Label();
            txtName = new TextBox();
            txtPassword = new TextBox();
            txtRole = new TextBox();
            txtUserID = new TextBox();
            txtSearch = new TextBox();
            dgvManageUsers = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnBack = new Button();
            cmbSearchBy = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvManageUsers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 22);
            label1.Name = "label1";
            label1.Size = new Size(238, 40);
            label1.TabIndex = 0;
            label1.Text = "Manage Users";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(37, 99);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 28);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(37, 146);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(118, 28);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.Black;
            lblRole.Location = new Point(37, 194);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(62, 28);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.BackColor = Color.Transparent;
            lblUserID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.Black;
            lblUserID.Location = new Point(37, 240);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(93, 28);
            lblUserID.TabIndex = 5;
            lblUserID.Text = "User ID";
            // 
            // lblSearchBy
            // 
            lblSearchBy.AutoSize = true;
            lblSearchBy.BackColor = Color.Transparent;
            lblSearchBy.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchBy.ForeColor = Color.Black;
            lblSearchBy.Location = new Point(677, 99);
            lblSearchBy.Name = "lblSearchBy";
            lblSearchBy.Size = new Size(100, 23);
            lblSearchBy.TabIndex = 6;
            lblSearchBy.Text = "Search By";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.Black;
            lblSearch.Location = new Point(695, 172);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(72, 23);
            lblSearch.TabIndex = 7;
            lblSearch.Text = "Search";
            // 
            // txtName
            // 
            txtName.Location = new Point(196, 99);
            txtName.Name = "txtName";
            txtName.Size = new Size(331, 31);
            txtName.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(196, 143);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(331, 31);
            txtPassword.TabIndex = 9;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(196, 194);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(331, 31);
            txtRole.TabIndex = 10;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(196, 240);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(331, 31);
            txtUserID.TabIndex = 11;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(622, 198);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(212, 31);
            txtSearch.TabIndex = 12;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvManageUsers
            // 
            dgvManageUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManageUsers.Location = new Point(37, 376);
            dgvManageUsers.Name = "dgvManageUsers";
            dgvManageUsers.RowHeadersWidth = 62;
            dgvManageUsers.Size = new Size(870, 225);
            dgvManageUsers.TabIndex = 14;
            dgvManageUsers.DoubleClick += dgvManageUsers_DoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RoyalBlue;
            btnAdd.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Transparent;
            btnAdd.Location = new Point(112, 298);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 55);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(414, 298);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 55);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Transparent;
            btnUpdate.Location = new Point(259, 298);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 55);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SlateGray;
            btnClear.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Transparent;
            btnClear.Location = new Point(568, 298);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 55);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.ForestGreen;
            btnBack.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(724, 298);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 55);
            btnBack.TabIndex = 19;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // cmbSearchBy
            // 
            cmbSearchBy.FormattingEnabled = true;
            cmbSearchBy.Items.AddRange(new object[] { "Name", "Role", "User ID" });
            cmbSearchBy.Location = new Point(622, 125);
            cmbSearchBy.Name = "cmbSearchBy";
            cmbSearchBy.Size = new Size(212, 33);
            cmbSearchBy.TabIndex = 20;
            cmbSearchBy.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Manage_Users
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(928, 613);
            Controls.Add(cmbSearchBy);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvManageUsers);
            Controls.Add(txtSearch);
            Controls.Add(txtUserID);
            Controls.Add(txtRole);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(lblSearch);
            Controls.Add(lblSearchBy);
            Controls.Add(lblUserID);
            Controls.Add(lblRole);
            Controls.Add(lblPassword);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "Manage_Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage_Users";
            ((System.ComponentModel.ISupportInitialize)dgvManageUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label lblPassword;
        private Label lblRole;
        private Label lblUserID;
        private Label lblSearchBy;
        private Label lblSearch;
        private TextBox txtName;
        private TextBox txtPassword;
        private TextBox txtRole;
        private TextBox txtUserID;
        private TextBox txtSearch;
        private DataGridView dgvManageUsers;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnBack;
        private ComboBox cmbSearchBy;
    }
}