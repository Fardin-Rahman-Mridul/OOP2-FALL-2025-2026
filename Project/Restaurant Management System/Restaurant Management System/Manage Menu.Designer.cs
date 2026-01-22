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
            label1 = new Label();
            lblFoodID = new Label();
            lblFoodName = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 9);
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
            lblFoodID.Location = new Point(32, 75);
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
            lblFoodName.Location = new Point(32, 135);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(129, 28);
            lblFoodName.TabIndex = 4;
            lblFoodName.Text = "FoodName";
            // 
            // Manage_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 545);
            Controls.Add(lblFoodName);
            Controls.Add(lblFoodID);
            Controls.Add(label1);
            Name = "Manage_Menu";
            Text = "Manage_Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblFoodID;
        private Label lblFoodName;
    }
}