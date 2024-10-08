﻿namespace PointOfSales2024.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
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
            Id = new DataGridViewTextBoxColumn();
            orderIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ProductId = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBarcodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            OrderQuantity = new DataGridViewTextBoxColumn();
            OverallPrice = new DataGridViewTextBoxColumn();
            transactedByDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateTimeTransactedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Cash = new DataGridViewTextBoxColumn();
            salesViewModelBindingSource = new BindingSource(components);
            label4 = new Label();
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
            groupBox1.Location = new Point(12, 45);
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
            btnSearch.BackColor = Color.SeaGreen;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(154, 129);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(166, 33);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search and Export";
            btnSearch.UseVisualStyleBackColor = false;
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
            groupBox2.Location = new Point(12, 229);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1094, 529);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(6, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(40, 34);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "X";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbltotalSales
            // 
            lbltotalSales.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbltotalSales.AutoSize = true;
            lbltotalSales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotalSales.Location = new Point(6, 492);
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
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, orderIdDataGridViewTextBoxColumn, ProductId, productNameDataGridViewTextBoxColumn, productBarcodeDataGridViewTextBoxColumn, Price, OrderQuantity, OverallPrice, transactedByDataGridViewTextBoxColumn, dateTimeTransactedDataGridViewTextBoxColumn, Cash });
            dataGridView1.DataSource = salesViewModelBindingSource;
            dataGridView1.Location = new Point(6, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1082, 412);
            dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            orderIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            orderIdDataGridViewTextBoxColumn.HeaderText = "Order Id";
            orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "ProductId";
            ProductId.Name = "ProductId";
            ProductId.ReadOnly = true;
            ProductId.Visible = false;
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
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // OrderQuantity
            // 
            OrderQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderQuantity.DataPropertyName = "OrderQuantity";
            OrderQuantity.HeaderText = "Order Quantity";
            OrderQuantity.Name = "OrderQuantity";
            OrderQuantity.ReadOnly = true;
            // 
            // OverallPrice
            // 
            OverallPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OverallPrice.DataPropertyName = "OverallPrice";
            OverallPrice.HeaderText = "Overall Price";
            OverallPrice.Name = "OverallPrice";
            OverallPrice.ReadOnly = true;
            // 
            // transactedByDataGridViewTextBoxColumn
            // 
            transactedByDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            transactedByDataGridViewTextBoxColumn.DataPropertyName = "TransactedBy";
            transactedByDataGridViewTextBoxColumn.HeaderText = "Transacted By";
            transactedByDataGridViewTextBoxColumn.Name = "transactedByDataGridViewTextBoxColumn";
            transactedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateTimeTransactedDataGridViewTextBoxColumn
            // 
            dateTimeTransactedDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateTimeTransactedDataGridViewTextBoxColumn.DataPropertyName = "DateTimeTransacted";
            dateTimeTransactedDataGridViewTextBoxColumn.HeaderText = "Date Time Transacted";
            dateTimeTransactedDataGridViewTextBoxColumn.Name = "dateTimeTransactedDataGridViewTextBoxColumn";
            dateTimeTransactedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Cash
            // 
            Cash.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cash.DataPropertyName = "Cash";
            Cash.HeaderText = "Cash";
            Cash.Name = "Cash";
            Cash.ReadOnly = true;
            // 
            // salesViewModelBindingSource
            // 
            salesViewModelBindingSource.DataSource = typeof(ViewModel.SalesViewModel);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 8);
            label4.Name = "label4";
            label4.Size = new Size(267, 28);
            label4.TabIndex = 9;
            label4.Text = "Sales Monitoring Form";
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1110, 770);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSearch;
        private BindingSource salesViewModelBindingSource;
        private DateTimePicker dtFrom;
        private DateTimePicker dtTo;
        private Label lbltotalSales;
        private Button btnDelete;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productBarcodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn OrderQuantity;
        private DataGridViewTextBoxColumn OverallPrice;
        private DataGridViewTextBoxColumn transactedByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateTimeTransactedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Cash;
        private Label label4;
    }
}