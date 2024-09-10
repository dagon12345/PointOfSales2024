namespace PointOfSales2024.Forms
{
    partial class TransactionForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnTransact = new Button();
            label8 = new Label();
            txtChange = new TextBox();
            label7 = new Label();
            txtCash = new TextBox();
            label4 = new Label();
            txtOverallTotal = new TextBox();
            groupBox2 = new GroupBox();
            lblNotification = new Label();
            label9 = new Label();
            lblProductId = new Label();
            txtProductName = new TextBox();
            label5 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtBarcode = new TextBox();
            btnEnter = new Button();
            label6 = new Label();
            txtOverallPrice = new TextBox();
            label2 = new Label();
            txtQuantity = new TextBox();
            productBindingSource = new BindingSource(components);
            productBindingSource1 = new BindingSource(components);
            productBindingSource2 = new BindingSource(components);
            productBindingSource3 = new BindingSource(components);
            groupBox3 = new GroupBox();
            btnVoid = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductId = new DataGridViewTextBoxColumn();
            barcodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            OverallPrice = new DataGridViewTextBoxColumn();
            orderViewModelBindingSource = new BindingSource(components);
            groupBox4 = new GroupBox();
            menuStrip1 = new MenuStrip();
            searchProductToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource3).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderViewModelBindingSource).BeginInit();
            groupBox4.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(btnTransact);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtChange);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCash);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtOverallTotal);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 476);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnTransact
            // 
            btnTransact.Cursor = Cursors.Hand;
            btnTransact.Location = new Point(56, 315);
            btnTransact.Name = "btnTransact";
            btnTransact.Size = new Size(317, 29);
            btnTransact.TabIndex = 22;
            btnTransact.Text = "&Transact(Alt + T)";
            btnTransact.UseVisualStyleBackColor = true;
            btnTransact.Click += btnTransact_Click;
            btnTransact.KeyDown += btnTransact_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(5, 224);
            label8.Name = "label8";
            label8.Size = new Size(54, 17);
            label8.TabIndex = 22;
            label8.Text = "Change";
            // 
            // txtChange
            // 
            txtChange.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChange.Location = new Point(6, 249);
            txtChange.Name = "txtChange";
            txtChange.ReadOnly = true;
            txtChange.Size = new Size(413, 43);
            txtChange.TabIndex = 22;
            txtChange.Text = "0.0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(5, 124);
            label7.Name = "label7";
            label7.Size = new Size(94, 17);
            label7.TabIndex = 20;
            label7.Text = "&Cash(Ctrl + C)";
            // 
            // txtCash
            // 
            txtCash.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCash.Location = new Point(6, 149);
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(413, 43);
            txtCash.TabIndex = 21;
            txtCash.Text = "0.0";
            txtCash.TextChanged += txtCash_TextChanged;
            txtCash.KeyDown += txtCash_KeyDown;
            txtCash.KeyPress += txtCash_KeyPress;
            txtCash.KeyUp += txtCash_KeyUp;
            txtCash.Leave += txtCash_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 18;
            label4.Text = "Overall Total";
            // 
            // txtOverallTotal
            // 
            txtOverallTotal.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOverallTotal.Location = new Point(7, 44);
            txtOverallTotal.Name = "txtOverallTotal";
            txtOverallTotal.ReadOnly = true;
            txtOverallTotal.Size = new Size(412, 55);
            txtOverallTotal.TabIndex = 17;
            txtOverallTotal.Text = "0.0";
            txtOverallTotal.KeyUp += txtOverallTotal_KeyUp;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(lblNotification);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(lblProductId);
            groupBox2.Controls.Add(txtProductName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtPrice);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtBarcode);
            groupBox2.Location = new Point(12, 509);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1016, 95);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // lblNotification
            // 
            lblNotification.AutoSize = true;
            lblNotification.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNotification.Location = new Point(7, 76);
            lblNotification.Name = "lblNotification";
            lblNotification.Size = new Size(68, 13);
            lblNotification.TabIndex = 22;
            lblNotification.Text = "Notification";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(709, 25);
            label9.Name = "label9";
            label9.Size = new Size(68, 17);
            label9.TabIndex = 21;
            label9.Text = "ProductId";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductId.Location = new Point(709, 46);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(23, 25);
            lblProductId.TabIndex = 20;
            lblProductId.Text = "0";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(238, 42);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Product Name";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(224, 29);
            txtProductName.TabIndex = 19;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(468, 22);
            label5.Name = "label5";
            label5.Size = new Size(38, 17);
            label5.TabIndex = 18;
            label5.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(468, 42);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(224, 29);
            txtPrice.TabIndex = 17;
            txtPrice.Text = "0.0";
            txtPrice.KeyUp += txtPrice_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(238, 22);
            label3.Name = "label3";
            label3.Size = new Size(152, 17);
            label3.TabIndex = 16;
            label3.Text = "Product Name(Ctrl + S)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 22);
            label1.Name = "label1";
            label1.Size = new Size(172, 17);
            label1.TabIndex = 12;
            label1.Text = "&Barcode Number (Ctrl + B)";
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBarcode.Location = new Point(7, 42);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.PlaceholderText = "Enter Barcode";
            txtBarcode.Size = new Size(224, 29);
            txtBarcode.TabIndex = 13;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            txtBarcode.KeyDown += txtBarcode_KeyDown;
            txtBarcode.KeyUp += txtBarcode_KeyUp;
            // 
            // btnEnter
            // 
            btnEnter.Cursor = Cursors.Hand;
            btnEnter.Location = new Point(468, 39);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(224, 29);
            btnEnter.TabIndex = 21;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(238, 19);
            label6.Name = "label6";
            label6.Size = new Size(86, 17);
            label6.TabIndex = 20;
            label6.Text = "Overall Price";
            // 
            // txtOverallPrice
            // 
            txtOverallPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOverallPrice.Location = new Point(238, 39);
            txtOverallPrice.Name = "txtOverallPrice";
            txtOverallPrice.ReadOnly = true;
            txtOverallPrice.Size = new Size(224, 29);
            txtOverallPrice.TabIndex = 19;
            txtOverallPrice.Text = "0.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 19);
            label2.Name = "label2";
            label2.Size = new Size(117, 17);
            label2.TabIndex = 14;
            label2.Text = "&Quantity(Alt + Q)";
            // 
            // txtQuantity
            // 
            txtQuantity.DataBindings.Add(new Binding("DataContext", productBindingSource, "Quantity", true));
            txtQuantity.DataBindings.Add(new Binding("Tag", productBindingSource1, "Quantity", true));
            txtQuantity.DataBindings.Add(new Binding("Text", productBindingSource2, "Quantity", true));
            txtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(7, 39);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(224, 29);
            txtQuantity.TabIndex = 15;
            txtQuantity.Text = "1";
            txtQuantity.KeyDown += txtQuantity_KeyDown;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            txtQuantity.KeyUp += txtQuantity_KeyUp;
            txtQuantity.Leave += txtQuantity_Leave;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // productBindingSource1
            // 
            productBindingSource1.DataSource = typeof(Models.Product);
            // 
            // productBindingSource2
            // 
            productBindingSource2.DataSource = typeof(Models.Product);
            // 
            // productBindingSource3
            // 
            productBindingSource3.DataSource = typeof(Models.Product);
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(btnVoid);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(456, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(572, 476);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // btnVoid
            // 
            btnVoid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoid.Cursor = Cursors.Hand;
            btnVoid.Location = new Point(7, 434);
            btnVoid.Name = "btnVoid";
            btnVoid.Size = new Size(149, 29);
            btnVoid.TabIndex = 22;
            btnVoid.Text = "Void Selected";
            btnVoid.UseVisualStyleBackColor = true;
            btnVoid.Click += btnVoid_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, ProductId, barcodeDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, Quantity, priceDataGridViewTextBoxColumn, OverallPrice });
            dataGridView1.DataSource = orderViewModelBindingSource;
            dataGridView1.Location = new Point(7, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(559, 414);
            dataGridView1.TabIndex = 0;
            dataGridView1.Leave += dataGridView1_Leave;
            dataGridView1.MouseLeave += dataGridView1_MouseLeave;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "ProductId";
            ProductId.Name = "ProductId";
            ProductId.ReadOnly = true;
            ProductId.Visible = false;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            barcodeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OverallPrice
            // 
            OverallPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OverallPrice.DataPropertyName = "OverallPrice";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            OverallPrice.DefaultCellStyle = dataGridViewCellStyle1;
            OverallPrice.HeaderText = "OverallPrice";
            OverallPrice.Name = "OverallPrice";
            OverallPrice.ReadOnly = true;
            // 
            // orderViewModelBindingSource
            // 
            orderViewModelBindingSource.DataSource = typeof(ViewModel.OrderViewModel);
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(txtQuantity);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(btnEnter);
            groupBox4.Controls.Add(txtOverallPrice);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(12, 601);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1016, 83);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { searchProductToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1040, 24);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // searchProductToolStripMenuItem
            // 
            searchProductToolStripMenuItem.Name = "searchProductToolStripMenuItem";
            searchProductToolStripMenuItem.Size = new Size(99, 20);
            searchProductToolStripMenuItem.Text = "&Search Product";
            searchProductToolStripMenuItem.Click += searchProductToolStripMenuItem_Click;
            // 
            // TransactionForm
            // 
            AcceptButton = btnEnter;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 709);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "TransactionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransactionForm";
            WindowState = FormWindowState.Maximized;
            Load += TransactionForm_Load;
            KeyDown += TransactionForm_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource3).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderViewModelBindingSource).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox txtQuantity;
        private Label label1;
        private TextBox txtBarcode;
        private Label label4;
        private TextBox txtOverallTotal;
        private Label label3;
        private DataGridView dataGridView1;
        private BindingSource orderViewModelBindingSource;
        private Label label6;
        private TextBox txtOverallPrice;
        private Label label5;
        private TextBox txtPrice;
        private Button btnEnter;
        private BindingSource productBindingSource;
        private BindingSource productBindingSource1;
        private BindingSource productBindingSource2;
        private BindingSource productBindingSource3;
        private GroupBox groupBox4;
        private Label label8;
        private TextBox txtChange;
        private Label label7;
        private TextBox txtCash;
        private Button btnTransact;
        private Label lblProductId;
        private Label label9;
        private Label lblNotification;
        private Button btnVoid;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn OverallPrice;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem searchProductToolStripMenuItem;
        public TextBox txtProductName;
    }
}