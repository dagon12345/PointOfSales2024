namespace PointOfSales2024.Forms
{
    partial class SalesForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dtTo = new DateTimePicker();
            dtFrom = new DateTimePicker();
            btnSearch = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            lbltotalSales = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBarcodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            orderQuantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            OverallPrice = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Cash = new DataGridViewTextBoxColumn();
            salesViewModelBindingSource = new BindingSource(components);
            bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dtTo);
            groupBox1.Controls.Add(dtFrom);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1094, 178);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dtTo
            // 
            dtTo.Location = new Point(154, 90);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(320, 23);
            dtTo.TabIndex = 7;
            // 
            // dtFrom
            // 
            dtFrom.Location = new Point(154, 51);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(320, 23);
            dtFrom.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(154, 129);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(166, 33);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search and Export";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 90);
            label3.Name = "label3";
            label3.Size = new Size(28, 21);
            label3.TabIndex = 2;
            label3.Text = "To:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 51);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 1;
            label2.Text = "From:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 0;
            label1.Text = "Date Search";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(lbltotalSales);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 184);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1094, 574);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(6, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(40, 34);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "X";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbltotalSales
            // 
            lbltotalSales.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbltotalSales.AutoSize = true;
            lbltotalSales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotalSales.Location = new Point(6, 537);
            lbltotalSales.Name = "lbltotalSales";
            lbltotalSales.Size = new Size(85, 21);
            lbltotalSales.TabIndex = 8;
            lbltotalSales.Text = "Total Sales:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, orderIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, productBarcodeDataGridViewTextBoxColumn, Price, orderQuantityDataGridViewTextBoxColumn, OverallPrice, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Cash });
            dataGridView1.DataSource = salesViewModelBindingSource;
            dataGridView1.Location = new Point(6, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1082, 457);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            orderIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            orderIdDataGridViewTextBoxColumn.HeaderText = "Order Id";
            orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBarcodeDataGridViewTextBoxColumn
            // 
            productBarcodeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productBarcodeDataGridViewTextBoxColumn.DataPropertyName = "ProductBarcode";
            productBarcodeDataGridViewTextBoxColumn.HeaderText = "Product Barcode";
            productBarcodeDataGridViewTextBoxColumn.Name = "productBarcodeDataGridViewTextBoxColumn";
            productBarcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            Price.DefaultCellStyle = dataGridViewCellStyle1;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // orderQuantityDataGridViewTextBoxColumn
            // 
            orderQuantityDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderQuantityDataGridViewTextBoxColumn.DataPropertyName = "OrderQuantity";
            orderQuantityDataGridViewTextBoxColumn.HeaderText = "Order Quantity";
            orderQuantityDataGridViewTextBoxColumn.Name = "orderQuantityDataGridViewTextBoxColumn";
            orderQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OverallPrice
            // 
            OverallPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OverallPrice.DataPropertyName = "OverallPrice";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            OverallPrice.DefaultCellStyle = dataGridViewCellStyle2;
            OverallPrice.HeaderText = "Overall Price";
            OverallPrice.Name = "OverallPrice";
            OverallPrice.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "TransactedBy";
            dataGridViewTextBoxColumn1.HeaderText = "Transacted By";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "DateTimeTransacted";
            dataGridViewTextBoxColumn2.HeaderText = "Date Time Transacted";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Cash
            // 
            Cash.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cash.DataPropertyName = "Cash";
            dataGridViewCellStyle3.Format = "C2";
            Cash.DefaultCellStyle = dataGridViewCellStyle3;
            Cash.HeaderText = "Cash";
            Cash.Name = "Cash";
            Cash.ReadOnly = true;
            // 
            // salesViewModelBindingSource
            // 
            salesViewModelBindingSource.DataSource = typeof(ViewModel.SalesViewModel);
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 770);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesForm";
            WindowState = FormWindowState.Maximized;
            Load += SalesForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesViewModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSearch;
        private DataGridViewTextBoxColumn transactedByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateTimeTransactedDataGridViewTextBoxColumn;
        private BindingSource salesViewModelBindingSource;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private DateTimePicker dtFrom;
        private DateTimePicker dtTo;
        private Label lbltotalSales;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productBarcodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn orderQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn OverallPrice;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Cash;
        private Button btnDelete;
    }
}