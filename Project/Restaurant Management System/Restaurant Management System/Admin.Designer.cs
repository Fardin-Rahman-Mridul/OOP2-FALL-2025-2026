namespace Restaurant_Management_System
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            btnManageMenu = new Button();
            btnManageUsers = new Button();
            btnLogOut = new Button();
            btnSalesReport = new Button();
            SuspendLayout();
            // 
            // btnManageMenu
            // 
            btnManageMenu.BackColor = Color.Maroon;
            btnManageMenu.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageMenu.ForeColor = Color.Transparent;
            btnManageMenu.Location = new Point(32, 54);
            btnManageMenu.Name = "btnManageMenu";
            btnManageMenu.Size = new Size(235, 55);
            btnManageMenu.TabIndex = 8;
            btnManageMenu.Text = "Manage Menu";
            btnManageMenu.UseVisualStyleBackColor = false;
            btnManageMenu.Click += btnManageMenu_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.BackColor = Color.Maroon;
            btnManageUsers.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageUsers.ForeColor = Color.Transparent;
            btnManageUsers.Location = new Point(32, 149);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(235, 55);
            btnManageUsers.TabIndex = 9;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = false;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Crimson;
            btnLogOut.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.Transparent;
            btnLogOut.Location = new Point(581, 325);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(159, 55);
            btnLogOut.TabIndex = 10;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnSalesReport
            // 
            btnSalesReport.BackColor = Color.Maroon;
            btnSalesReport.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalesReport.ForeColor = Color.Transparent;
            btnSalesReport.Location = new Point(32, 243);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(235, 55);
            btnSalesReport.TabIndex = 11;
            btnSalesReport.Text = "Sales Report";
            btnSalesReport.UseVisualStyleBackColor = false;
            btnSalesReport.Click += btnSalesReport_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalesReport);
            Controls.Add(btnLogOut);
            Controls.Add(btnManageUsers);
            Controls.Add(btnManageMenu);
            DoubleBuffered = true;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ResumeLayout(false);
        }

        #endregion
        private Button btnManageMenu;
        private Button btnManageUsers;
        private Button btnLogOut;
        private Button btnSalesReport;
    }
}