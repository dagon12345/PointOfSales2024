namespace PointOfSales2024.Forms
{
    partial class UsersPasswordForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            AppUserId = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            appUserBindingSource = new BindingSource(components);
            txtNewPassword = new TextBox();
            label3 = new Label();
            lblAppUserId = new Label();
            btUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appUserBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 29);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 11;
            label1.Text = "Current Username";
            label1.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(153, 28);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(224, 23);
            txtUsername.TabIndex = 20;
            txtUsername.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(153, 57);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(224, 23);
            txtPassword.TabIndex = 22;
            txtPassword.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 58);
            label2.Name = "label2";
            label2.Size = new Size(116, 17);
            label2.TabIndex = 21;
            label2.Text = "Current Password";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AppUserId, Name, UserName, Password });
            dataGridView1.DataSource = appUserBindingSource;
            dataGridView1.Location = new Point(12, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(618, 269);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // AppUserId
            // 
            AppUserId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AppUserId.DataPropertyName = "AppUserId";
            AppUserId.HeaderText = "AppUserId";
            AppUserId.Name = "AppUserId";
            AppUserId.ReadOnly = true;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // UserName
            // 
            UserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "UserName";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // appUserBindingSource
            // 
            appUserBindingSource.DataSource = typeof(Models.AppUser);
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(153, 96);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(224, 23);
            txtNewPassword.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 96);
            label3.Name = "label3";
            label3.Size = new Size(97, 17);
            label3.TabIndex = 24;
            label3.Text = "New Password";
            // 
            // lblAppUserId
            // 
            lblAppUserId.AutoSize = true;
            lblAppUserId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppUserId.Location = new Point(153, 9);
            lblAppUserId.Name = "lblAppUserId";
            lblAppUserId.Size = new Size(80, 17);
            lblAppUserId.TabIndex = 26;
            lblAppUserId.Text = "App User Id";
            lblAppUserId.Visible = false;
            // 
            // btUpdate
            // 
            btUpdate.Image = Properties.Resources.icons8_refresh_25;
            btUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btUpdate.Location = new Point(153, 130);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(140, 38);
            btUpdate.TabIndex = 27;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // UsersPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(642, 455);
            Controls.Add(btUpdate);
            Controls.Add(lblAppUserId);
            Controls.Add(txtNewPassword);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(658, 494);
            MinimizeBox = false;
            MinimumSize = new Size(658, 494);

            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsersPasswordForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)appUserBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn AppUserId;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Password;
        private BindingSource appUserBindingSource;
        private TextBox txtNewPassword;
        private Label label3;
        private Label lblAppUserId;
        private Button btUpdate;
    }
}