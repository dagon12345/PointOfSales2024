namespace PointOfSales2024.Forms
{
    partial class RegisterForm
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
            groupBox1 = new GroupBox();
            checkAdmin = new CheckBox();
            btnRegister = new Button();
            txtFullname = new TextBox();
            label4 = new Label();
            txtPass = new TextBox();
            label3 = new Label();
            txtConfirmPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkAdmin);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(txtFullname);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtConfirmPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 310);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // checkAdmin
            // 
            checkAdmin.AutoSize = true;
            checkAdmin.Location = new Point(13, 247);
            checkAdmin.Name = "checkAdmin";
            checkAdmin.Size = new Size(96, 19);
            checkAdmin.TabIndex = 4;
            checkAdmin.Text = "Adminstrator";
            checkAdmin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(13, 272);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(140, 32);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtFullname
            // 
            txtFullname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullname.Location = new Point(13, 38);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(250, 23);
            txtFullname.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 15);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 9;
            label4.Text = "Full Name";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(13, 158);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(250, 23);
            txtPass.TabIndex = 2;
            txtPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 135);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(13, 217);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(250, 23);
            txtConfirmPassword.TabIndex = 3;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(13, 98);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 23);
            txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 194);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 3;
            label2.Text = "Confirm Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 75);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 334);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(345, 373);
            MinimizeBox = false;
            MinimumSize = new Size(345, 373);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtFullname;
        private Label label4;
        private TextBox txtPass;
        private Label label3;
        private TextBox txtConfirmPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Button btnRegister;
        private CheckBox checkAdmin;
    }
}