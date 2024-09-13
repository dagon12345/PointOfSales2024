namespace PointOfSales2024.Forms
{
    partial class DashboardForm
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
            btnAddproduct = new Button();
            btnAddStocks = new Button();
            btnTransact = new Button();
            btnSales = new Button();
            btnAddedStocks = new Button();
            statusStrip1 = new StatusStrip();
            txtName = new ToolStripStatusLabel();
            txtRole = new ToolStripStatusLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            registerUsersToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddproduct
            // 
            btnAddproduct.BackColor = Color.SteelBlue;
            btnAddproduct.Cursor = Cursors.Hand;
            btnAddproduct.FlatAppearance.BorderSize = 0;
            btnAddproduct.FlatStyle = FlatStyle.Flat;
            btnAddproduct.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            btnAddproduct.ForeColor = Color.White;
            btnAddproduct.Image = Properties.Resources._299068_add_sign_icon;
            btnAddproduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddproduct.Location = new Point(12, 109);
            btnAddproduct.Name = "btnAddproduct";
            btnAddproduct.Size = new Size(279, 70);
            btnAddproduct.TabIndex = 0;
            btnAddproduct.Text = "Add new/Update Product";
            btnAddproduct.UseVisualStyleBackColor = false;
            btnAddproduct.Click += btnAddproduct_Click;
            // 
            // btnAddStocks
            // 
            btnAddStocks.BackColor = Color.SteelBlue;
            btnAddStocks.Cursor = Cursors.Hand;
            btnAddStocks.FlatAppearance.BorderSize = 0;
            btnAddStocks.FlatStyle = FlatStyle.Flat;
            btnAddStocks.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            btnAddStocks.ForeColor = Color.White;
            btnAddStocks.Image = Properties.Resources._7341111_e_commerce_online_shopping_ui_box_package_icon;
            btnAddStocks.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddStocks.Location = new Point(12, 191);
            btnAddStocks.Name = "btnAddStocks";
            btnAddStocks.Size = new Size(279, 70);
            btnAddStocks.TabIndex = 0;
            btnAddStocks.Text = "Add Stocks";
            btnAddStocks.UseVisualStyleBackColor = false;
            btnAddStocks.Click += btnAddStocks_Click;
            // 
            // btnTransact
            // 
            btnTransact.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTransact.BackColor = Color.SteelBlue;
            btnTransact.Cursor = Cursors.Hand;
            btnTransact.FlatAppearance.BorderSize = 0;
            btnTransact.FlatStyle = FlatStyle.Flat;
            btnTransact.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransact.ForeColor = Color.White;
            btnTransact.Image = Properties.Resources.icons8_approved_50;
            btnTransact.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransact.Location = new Point(12, 499);
            btnTransact.Name = "btnTransact";
            btnTransact.Size = new Size(282, 105);
            btnTransact.TabIndex = 0;
            btnTransact.Text = "Transact";
            btnTransact.UseVisualStyleBackColor = false;
            btnTransact.Click += btnTransact_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.SteelBlue;
            btnSales.Cursor = Cursors.Hand;
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            btnSales.ForeColor = Color.White;
            btnSales.Image = Properties.Resources._2303181_bar_chart_diagram_line_report_icon;
            btnSales.ImageAlign = ContentAlignment.MiddleLeft;
            btnSales.Location = new Point(12, 273);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(279, 70);
            btnSales.TabIndex = 1;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnAddedStocks
            // 
            btnAddedStocks.BackColor = Color.SteelBlue;
            btnAddedStocks.Cursor = Cursors.Hand;
            btnAddedStocks.FlatAppearance.BorderSize = 0;
            btnAddedStocks.FlatStyle = FlatStyle.Flat;
            btnAddedStocks.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            btnAddedStocks.ForeColor = Color.White;
            btnAddedStocks.Image = Properties.Resources._49364_box_crate_delivery_entrega_inventory_icon;
            btnAddedStocks.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddedStocks.Location = new Point(12, 355);
            btnAddedStocks.Name = "btnAddedStocks";
            btnAddedStocks.Size = new Size(279, 70);
            btnAddedStocks.TabIndex = 2;
            btnAddedStocks.Text = "Added stocks";
            btnAddedStocks.UseVisualStyleBackColor = false;
            btnAddedStocks.Click += btnAddedStocks_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { txtName, txtRole });
            statusStrip1.Location = new Point(0, 646);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1073, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // txtName
            // 
            txtName.Name = "txtName";
            txtName.Size = new Size(39, 17);
            txtName.Text = "Name";
            // 
            // txtRole
            // 
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(30, 17);
            txtRole.Text = "Role";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnAddproduct);
            panel1.Controls.Add(btnAddStocks);
            panel1.Controls.Add(btnSales);
            panel1.Controls.Add(btnTransact);
            panel1.Controls.Add(btnAddedStocks);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 622);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(88, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 72);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(94, 37);
            label2.TabIndex = 1;
            label2.Text = "E-POS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 44);
            label1.Name = "label1";
            label1.Size = new Size(200, 25);
            label1.TabIndex = 0;
            label1.Text = "Point of Sales System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Espina_POS;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SteelBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { registerUsersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1073, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // registerUsersToolStripMenuItem
            // 
            registerUsersToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerUsersToolStripMenuItem.ForeColor = Color.White;
            registerUsersToolStripMenuItem.Name = "registerUsersToolStripMenuItem";
            registerUsersToolStripMenuItem.Size = new Size(100, 20);
            registerUsersToolStripMenuItem.Text = "Register Users";
            registerUsersToolStripMenuItem.Click += registerUsersToolStripMenuItem_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1073, 668);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            WindowState = FormWindowState.Maximized;
            FormClosed += DashboardForm_FormClosed;
            Load += DashboardForm_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddproduct;
        private Button btnAddStocks;
        private Button btnTransact;
        private Button btnSales;
        private Button btnAddedStocks;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel txtName;
        private ToolStripStatusLabel txtRole;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem registerUsersToolStripMenuItem;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}