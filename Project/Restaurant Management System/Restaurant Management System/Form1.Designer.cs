namespace Restaurant_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lblUserID = new Label();
            lblPassword = new Label();
            txtUserID = new TextBox();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            btnClear = new Button();
            btnCustomerSignUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Britannic Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(320, 63);
            label1.Name = "label1";
            label1.Size = new Size(468, 36);
            label1.TabIndex = 0;
            label1.Text = "Restaurant Management System";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.BackColor = SystemColors.ActiveCaption;
            lblUserID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = SystemColors.ActiveCaptionText;
            lblUserID.Location = new Point(327, 161);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(93, 28);
            lblUserID.TabIndex = 1;
            lblUserID.Text = "User ID";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = SystemColors.ActiveCaption;
            lblPassword.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.ActiveCaptionText;
            lblPassword.Location = new Point(327, 217);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(118, 28);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtUserID
            // 
            txtUserID.BackColor = SystemColors.ActiveCaption;
            txtUserID.ForeColor = SystemColors.ActiveCaptionText;
            txtUserID.Location = new Point(468, 161);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(282, 31);
            txtUserID.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ActiveCaption;
            txtPassword.ForeColor = SystemColors.ActiveCaptionText;
            txtPassword.Location = new Point(468, 214);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(282, 31);
            txtPassword.TabIndex = 4;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = SystemColors.ActiveCaption;
            chkShowPassword.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = SystemColors.ActiveCaptionText;
            chkShowPassword.Location = new Point(468, 269);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(148, 24);
            chkShowPassword.TabIndex = 5;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.Font = new Font("Palatino Linotype", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(468, 327);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(124, 55);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Brown;
            btnClear.Font = new Font("Palatino Linotype", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(626, 327);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 55);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCustomerSignUp
            // 
            btnCustomerSignUp.BackColor = SystemColors.MenuHighlight;
            btnCustomerSignUp.Font = new Font("Palatino Linotype", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerSignUp.ForeColor = Color.White;
            btnCustomerSignUp.Location = new Point(468, 409);
            btnCustomerSignUp.Name = "btnCustomerSignUp";
            btnCustomerSignUp.Size = new Size(301, 55);
            btnCustomerSignUp.TabIndex = 8;
            btnCustomerSignUp.Text = "Customer Sign Up";
            btnCustomerSignUp.UseVisualStyleBackColor = false;
            btnCustomerSignUp.Click += btnCustomerSignUp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(823, 500);
            Controls.Add(btnCustomerSignUp);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserID);
            Controls.Add(lblPassword);
            Controls.Add(lblUserID);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUserID;
        private Label lblPassword;
        private TextBox txtUserID;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Button btnClear;
        private Button btnCustomerSignUp;
    }
}
