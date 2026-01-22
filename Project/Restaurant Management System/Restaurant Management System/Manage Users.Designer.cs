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
            lbl = new Label();
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
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.Black;
            lbl.Location = new Point(639, 99);
            lbl.Name = "lbl";
            lbl.Size = new Size(120, 28);
            lbl.TabIndex = 6;
            lbl.Text = "Search By";
            // 
            // Manage_Users
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 533);
            Controls.Add(lbl);
            Controls.Add(lblUserID);
            Controls.Add(lblRole);
            Controls.Add(lblPassword);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "Manage_Users";
            Text = "Manage_Users";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label lblPassword;
        private Label lblRole;
        private Label lblUserID;
        private Label lbl;
    }
}