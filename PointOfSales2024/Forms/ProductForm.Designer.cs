using System.Windows.Forms;

namespace PointOfSales2024
{
    partial class ProductForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            btn_save = new Button();
            check_barcode = new CheckBox();
            txt_barcodenumber = new TextBox();
            txt_productName = new TextBox();
            txt_quantity = new TextBox();
            txt_price = new TextBox();
            productBindingSource = new BindingSource(components);
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_remove = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            isBarcodeDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            barcodeNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            OverallTotal = new DataGridViewTextBoxColumn();
            AddedBy = new DataGridViewTextBoxColumn();
            dateAddedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productViewModelBindingSource = new BindingSource(components);
            txt_search = new TextBox();
            label2 = new Label();
            lblProductId = new Label();
            label6 = new Label();
            lblStatus = new Label();
            btnRefresh = new Button();
            btnClear = new Button();
            label7 = new Label();
            lblCount = new Label();
            lblAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.Cursor = Cursors.Hand;
            btn_save.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.Image = Properties.Resources.icons8_save_25;
            btn_save.ImageAlign = ContentAlignment.MiddleLeft;
            btn_save.Location = new Point(131, 257);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(224, 32);
            btn_save.TabIndex = 4;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // check_barcode
            // 
            check_barcode.AutoSize = true;
            check_barcode.Checked = true;
            check_barcode.CheckState = CheckState.Checked;
            check_barcode.Location = new Point(361, 85);
            check_barcode.Name = "check_barcode";
            check_barcode.Size = new Size(69, 19);
            check_barcode.TabIndex = 8;
            check_barcode.Text = "Barcode";
            check_barcode.UseVisualStyleBackColor = true;
            check_barcode.CheckedChanged += check_barcode_CheckedChanged;
            // 
            // txt_barcodenumber
            // 
            txt_barcodenumber.Location = new Point(131, 83);
            txt_barcodenumber.Name = "txt_barcodenumber";
            txt_barcodenumber.Size = new Size(224, 23);
            txt_barcodenumber.TabIndex = 0;
            // 
            // txt_productName
            // 
            txt_productName.Location = new Point(131, 116);
            txt_productName.Name = "txt_productName";
            txt_productName.Size = new Size(224, 23);
            txt_productName.TabIndex = 1;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(131, 152);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(224, 23);
            txt_quantity.TabIndex = 2;
            txt_quantity.KeyPress += txt_quantity_KeyPress;
            // 
            // txt_price
            // 
            txt_price.DataBindings.Add(new Binding("Text", productBindingSource, "Price", true, DataSourceUpdateMode.OnValidation, "0", "C1"));
            txt_price.Location = new Point(131, 191);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(224, 23);
            txt_price.TabIndex = 3;
            txt_price.KeyPress += txt_price_KeyPress;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 83);
            label1.Name = "label1";
            label1.Size = new Size(111, 17);
            label1.TabIndex = 10;
            label1.Text = "Barcode Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 116);
            label3.Name = "label3";
            label3.Size = new Size(96, 17);
            label3.TabIndex = 12;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(57, 152);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 12;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(81, 191);
            label5.Name = "label5";
            label5.Size = new Size(38, 17);
            label5.TabIndex = 12;
            label5.Text = "Price";
            // 
            // btn_remove
            // 
            btn_remove.Cursor = Cursors.Hand;
            btn_remove.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_remove.Image = Properties.Resources.icons8_delete_25;
            btn_remove.ImageAlign = ContentAlignment.MiddleLeft;
            btn_remove.Location = new Point(131, 295);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(224, 34);
            btn_remove.TabIndex = 5;
            btn_remove.Text = "Delete";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, isBarcodeDataGridViewCheckBoxColumn, barcodeNumberDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, Quantity, Price, OverallTotal, AddedBy, dateAddedDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productViewModelBindingSource;
            dataGridView1.Location = new Point(12, 402);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(932, 252);
            dataGridView1.TabIndex = 8;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // isBarcodeDataGridViewCheckBoxColumn
            // 
            isBarcodeDataGridViewCheckBoxColumn.DataPropertyName = "IsBarcode";
            isBarcodeDataGridViewCheckBoxColumn.HeaderText = "Barcode";
            isBarcodeDataGridViewCheckBoxColumn.Name = "isBarcodeDataGridViewCheckBoxColumn";
            isBarcodeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // barcodeNumberDataGridViewTextBoxColumn
            // 
            barcodeNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            barcodeNumberDataGridViewTextBoxColumn.DataPropertyName = "BarcodeNumber";
            barcodeNumberDataGridViewTextBoxColumn.HeaderText = "Barcode Number";
            barcodeNumberDataGridViewTextBoxColumn.Name = "barcodeNumberDataGridViewTextBoxColumn";
            barcodeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 78;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 58;
            // 
            // OverallTotal
            // 
            OverallTotal.DataPropertyName = "OverallTotal";
            OverallTotal.HeaderText = "Overall Total";
            OverallTotal.Name = "OverallTotal";
            OverallTotal.ReadOnly = true;
            // 
            // AddedBy
            // 
            AddedBy.DataPropertyName = "AddedBy";
            AddedBy.HeaderText = "Added By";
            AddedBy.Name = "AddedBy";
            AddedBy.ReadOnly = true;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            dateAddedDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            dateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded";
            dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            dateAddedDataGridViewTextBoxColumn.ReadOnly = true;
            dateAddedDataGridViewTextBoxColumn.Width = 91;
            // 
            // productViewModelBindingSource
            // 
            productViewModelBindingSource.DataSource = typeof(ViewModel.ProductViewModel);
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_search.Location = new Point(81, 365);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Search product name or barcode";
            txt_search.Size = new Size(334, 29);
            txt_search.TabIndex = 7;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 49);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 14;
            label2.Text = "Product Id";
            label2.Visible = false;
            label2.Click += label2_Click;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductId.Location = new Point(131, 50);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(15, 17);
            lblProductId.TabIndex = 14;
            lblProductId.Text = "0";
            lblProductId.Visible = false;
            lblProductId.Click += label2_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(754, 384);
            label6.Name = "label6";
            label6.Size = new Size(189, 15);
            label6.TabIndex = 15;
            label6.Text = "Click the product below to update.";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(6, 3);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(117, 15);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Status: Add Product";
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Image = Properties.Resources.icons8_refresh_25;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(421, 364);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(92, 33);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Image = Properties.Resources.icons8_clear_25;
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.Location = new Point(131, 220);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.MiddleRight;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 369);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 17;
            label7.Text = "Search";
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(12, 657);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(150, 21);
            lblCount.TabIndex = 18;
            lblCount.Text = "Product entered: 0";
            // 
            // lblAmount
            // 
            lblAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(12, 686);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(192, 21);
            lblAmount.TabIndex = 19;
            lblAmount.Text = "Total amount entered: 0";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(957, 724);
            Controls.Add(lblAmount);
            Controls.Add(lblCount);
            Controls.Add(label7);
            Controls.Add(btnClear);
            Controls.Add(btnRefresh);
            Controls.Add(lblStatus);
            Controls.Add(label6);
            Controls.Add(lblProductId);
            Controls.Add(label2);
            Controls.Add(txt_search);
            Controls.Add(dataGridView1);
            Controls.Add(btn_remove);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txt_price);
            Controls.Add(txt_quantity);
            Controls.Add(txt_productName);
            Controls.Add(txt_barcodenumber);
            Controls.Add(check_barcode);
            Controls.Add(btn_save);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Form";
            WindowState = FormWindowState.Maximized;
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn addedByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private BindingSource productViewModelBindingSource;
        private DataGridViewCheckBoxColumn isWholeSaleDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn wholeSaleQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private TextBox txt_search;
        private BindingSource productBindingSource;
        private Label label2;
        private Label lblProductId;
        private Label label6;
        public Button btn_save;
        public CheckBox check_barcode;
        public TextBox txt_barcodenumber;
        public TextBox txt_productName;
        public TextBox txt_quantity;
        public TextBox txt_price;
        public Button btn_remove;
        public Label lblStatus;
        public Button btnRefresh;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewCheckBoxColumn isBarcodeDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn barcodeNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn OverallTotal;
        private DataGridViewTextBoxColumn AddedBy;
        private DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        public Button btnClear;
        private Label label7;
        private Label lblCount;
        private Label lblAmount;
    }
}
