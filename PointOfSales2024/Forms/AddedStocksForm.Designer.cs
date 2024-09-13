namespace PointOfSales2024.Forms
{
    partial class AddedStocksForm
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
            dgAddedStocks = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductId = new DataGridViewTextBoxColumn();
            barcodeNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            addedByDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            QuantityAdded = new DataGridViewTextBoxColumn();
            dateAddedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addedStocksViewModelBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            dtTo = new DateTimePicker();
            dtFrom = new DateTimePicker();
            btnSearch = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            lblQuantity = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgAddedStocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addedStocksViewModelBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgAddedStocks
            // 
            dgAddedStocks.AllowUserToAddRows = false;
            dgAddedStocks.AllowUserToDeleteRows = false;
            dgAddedStocks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgAddedStocks.AutoGenerateColumns = false;
            dgAddedStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAddedStocks.Columns.AddRange(new DataGridViewColumn[] { Id, ProductId, barcodeNumberDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, Price, addedByDataGridViewTextBoxColumn, QuantityAdded, dateAddedDataGridViewTextBoxColumn });
            dgAddedStocks.DataSource = addedStocksViewModelBindingSource;
            dgAddedStocks.Location = new Point(12, 287);
            dgAddedStocks.Name = "dgAddedStocks";
            dgAddedStocks.ReadOnly = true;
            dgAddedStocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAddedStocks.Size = new Size(1082, 389);
            dgAddedStocks.TabIndex = 0;
            // 
            // Id
            // 
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
            // barcodeNumberDataGridViewTextBoxColumn
            // 
            barcodeNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            barcodeNumberDataGridViewTextBoxColumn.DataPropertyName = "BarcodeNumber";
            barcodeNumberDataGridViewTextBoxColumn.HeaderText = "BarcodeNumber";
            barcodeNumberDataGridViewTextBoxColumn.Name = "barcodeNumberDataGridViewTextBoxColumn";
            barcodeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // addedByDataGridViewTextBoxColumn
            // 
            addedByDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            addedByDataGridViewTextBoxColumn.DataPropertyName = "AddedBy";
            addedByDataGridViewTextBoxColumn.HeaderText = "AddedBy";
            addedByDataGridViewTextBoxColumn.Name = "addedByDataGridViewTextBoxColumn";
            addedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // QuantityAdded
            // 
            QuantityAdded.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QuantityAdded.DataPropertyName = "QuantityAdded";
            QuantityAdded.HeaderText = "QuantityAdded";
            QuantityAdded.Name = "QuantityAdded";
            QuantityAdded.ReadOnly = true;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            dateAddedDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            dateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded";
            dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            dateAddedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addedStocksViewModelBindingSource
            // 
            addedStocksViewModelBindingSource.DataSource = typeof(ViewModel.AddedStocksViewModel);
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
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1082, 178);
            groupBox1.TabIndex = 1;
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
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(12, 247);
            button1.Name = "button1";
            button1.Size = new Size(40, 34);
            button1.TabIndex = 16;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(12, 689);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(103, 20);
            lblQuantity.TabIndex = 17;
            lblQuantity.Text = "Added Stocks:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 19);
            label4.Name = "label4";
            label4.Size = new Size(288, 28);
            label4.TabIndex = 8;
            label4.Text = "Added Stocks Inventory";
            // 
            // AddedStocksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1106, 726);
            Controls.Add(label4);
            Controls.Add(lblQuantity);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(dgAddedStocks);
            Name = "AddedStocksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddedStocksForm";
            WindowState = FormWindowState.Maximized;
            Load += AddedStocksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgAddedStocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)addedStocksViewModelBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgAddedStocks;
        private BindingSource addedStocksViewModelBindingSource;
        private GroupBox groupBox1;
        private DateTimePicker dtTo;
        private DateTimePicker dtFrom;
        private Button btnSearch;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label lblQuantity;
        private Label label4;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn barcodeNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn addedByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn QuantityAdded;
        private DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
    }
}