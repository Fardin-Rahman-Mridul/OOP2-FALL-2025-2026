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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(163, 50);
            label1.Name = "label1";
            label1.Size = new Size(468, 36);
            label1.TabIndex = 0;
            label1.Text = "Restaurant Management System";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.BackColor = Color.Transparent;
            lblUserID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.MintCream;
            lblUserID.Location = new Point(170, 148);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(93, 28);
            lblUserID.TabIndex = 1;
            lblUserID.Text = "User ID";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.MintCream;
            lblPassword.Location = new Point(170, 204);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(118, 28);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtUserID
            // 
            txtUserID.BackColor = Color.LightCyan;
            txtUserID.Location = new Point(311, 148);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(282, 31);
            txtUserID.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.LightCyan;
            txtPassword.Location = new Point(311, 201);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(282, 31);
            txtPassword.TabIndex = 4;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.LightCyan;
            chkShowPassword.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(311, 256);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(148, 24);
            chkShowPassword.TabIndex = 5;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.Font = new Font("Palatino Linotype", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(311, 314);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(124, 55);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SlateGray;
            btnClear.Font = new Font("Palatino Linotype", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Transparent;
            btnClear.Location = new Point(469, 314);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 55);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserID);
            Controls.Add(lblPassword);
            Controls.Add(lblUserID);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
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
    }
}
