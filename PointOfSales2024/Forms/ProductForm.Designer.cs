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
            btn_save = new Button();
            check_barcode = new CheckBox();
            txt_barcodenumber = new TextBox();
            ck_wholesale = new CheckBox();
            txt_wholeSaleQuantity = new TextBox();
            productBindingSource = new BindingSource(components);
            productBindingSource1 = new BindingSource(components);
            txt_productName = new TextBox();
            txt_quantity = new TextBox();
            txt_price = new TextBox();
            txt_profit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_remove = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            isBarcodeDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            barcodeNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isWholeSaleDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            wholeSaleQuantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            profitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateAddedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productViewModelBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.Cursor = Cursors.Hand;
            btn_save.Location = new Point(13, 206);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(112, 34);
            btn_save.TabIndex = 6;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // check_barcode
            // 
            check_barcode.AutoSize = true;
            check_barcode.Checked = true;
            check_barcode.CheckState = CheckState.Checked;
            check_barcode.Location = new Point(154, 23);
            check_barcode.Name = "check_barcode";
            check_barcode.Size = new Size(69, 19);
            check_barcode.TabIndex = 2;
            check_barcode.Text = "Barcode";
            check_barcode.UseVisualStyleBackColor = true;
            // 
            // txt_barcodenumber
            // 
            txt_barcodenumber.Location = new Point(13, 45);
            txt_barcodenumber.Name = "txt_barcodenumber";
            txt_barcodenumber.Size = new Size(224, 23);
            txt_barcodenumber.TabIndex = 0;
            // 
            // ck_wholesale
            // 
            ck_wholesale.AutoSize = true;
            ck_wholesale.Location = new Point(154, 86);
            ck_wholesale.Name = "ck_wholesale";
            ck_wholesale.Size = new Size(81, 19);
            ck_wholesale.TabIndex = 4;
            ck_wholesale.Text = "WholeSale";
            ck_wholesale.UseVisualStyleBackColor = true;
            ck_wholesale.CheckedChanged += ck_wholesale_CheckedChanged;
            // 
            // txt_wholeSaleQuantity
            // 
            txt_wholeSaleQuantity.DataBindings.Add(new Binding("Text", productBindingSource, "wholeSaleQuantity", true, DataSourceUpdateMode.Never, "0", "N0"));
            txt_wholeSaleQuantity.DataBindings.Add(new Binding("WordWrap", productBindingSource1, "wholeSaleQuantity", true, DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            txt_wholeSaleQuantity.Enabled = false;
            txt_wholeSaleQuantity.Location = new Point(13, 108);
            txt_wholeSaleQuantity.Name = "txt_wholeSaleQuantity";
            txt_wholeSaleQuantity.Size = new Size(224, 23);
            txt_wholeSaleQuantity.TabIndex = 1;
            txt_wholeSaleQuantity.Text = "0";
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // productBindingSource1
            // 
            productBindingSource1.DataSource = typeof(Models.Product);
            // 
            // txt_productName
            // 
            txt_productName.Location = new Point(13, 168);
            txt_productName.Name = "txt_productName";
            txt_productName.Size = new Size(224, 23);
            txt_productName.TabIndex = 2;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(252, 45);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(224, 23);
            txt_quantity.TabIndex = 3;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(252, 108);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(224, 23);
            txt_price.TabIndex = 4;
            // 
            // txt_profit
            // 
            txt_profit.Location = new Point(252, 168);
            txt_profit.Name = "txt_profit";
            txt_profit.Size = new Size(224, 23);
            txt_profit.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 24);
            label1.Name = "label1";
            label1.Size = new Size(111, 17);
            label1.TabIndex = 10;
            label1.Text = "Barcode Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 87);
            label2.Name = "label2";
            label2.Size = new Size(135, 17);
            label2.TabIndex = 11;
            label2.Text = "Whole Sale Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 147);
            label3.Name = "label3";
            label3.Size = new Size(96, 17);
            label3.TabIndex = 12;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(252, 25);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 12;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(252, 90);
            label5.Name = "label5";
            label5.Size = new Size(38, 17);
            label5.TabIndex = 12;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(252, 145);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 12;
            label6.Text = "Profit";
            // 
            // btn_remove
            // 
            btn_remove.Cursor = Cursors.Hand;
            btn_remove.Location = new Point(13, 246);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(112, 34);
            btn_remove.TabIndex = 7;
            btn_remove.Text = "Delete";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, isBarcodeDataGridViewCheckBoxColumn, barcodeNumberDataGridViewTextBoxColumn, isWholeSaleDataGridViewCheckBoxColumn, wholeSaleQuantityDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, profitDataGridViewTextBoxColumn, dateAddedDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productViewModelBindingSource;
            dataGridView1.Location = new Point(13, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(932, 378);
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
            barcodeNumberDataGridViewTextBoxColumn.DataPropertyName = "BarcodeNumber";
            barcodeNumberDataGridViewTextBoxColumn.HeaderText = "Barcode Number";
            barcodeNumberDataGridViewTextBoxColumn.Name = "barcodeNumberDataGridViewTextBoxColumn";
            barcodeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isWholeSaleDataGridViewCheckBoxColumn
            // 
            isWholeSaleDataGridViewCheckBoxColumn.DataPropertyName = "IsWholeSale";
            isWholeSaleDataGridViewCheckBoxColumn.HeaderText = "Whole Sale";
            isWholeSaleDataGridViewCheckBoxColumn.Name = "isWholeSaleDataGridViewCheckBoxColumn";
            isWholeSaleDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // wholeSaleQuantityDataGridViewTextBoxColumn
            // 
            wholeSaleQuantityDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            wholeSaleQuantityDataGridViewTextBoxColumn.DataPropertyName = "wholeSaleQuantity";
            wholeSaleQuantityDataGridViewTextBoxColumn.HeaderText = "Whole Sale Quantity";
            wholeSaleQuantityDataGridViewTextBoxColumn.Name = "wholeSaleQuantityDataGridViewTextBoxColumn";
            wholeSaleQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            wholeSaleQuantityDataGridViewTextBoxColumn.Width = 127;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 78;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 58;
            // 
            // profitDataGridViewTextBoxColumn
            // 
            profitDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
            profitDataGridViewTextBoxColumn.HeaderText = "Profit";
            profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            profitDataGridViewTextBoxColumn.ReadOnly = true;
            profitDataGridViewTextBoxColumn.Width = 61;
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
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 677);
            Controls.Add(dataGridView1);
            Controls.Add(btn_remove);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_profit);
            Controls.Add(txt_price);
            Controls.Add(txt_quantity);
            Controls.Add(txt_productName);
            Controls.Add(txt_wholeSaleQuantity);
            Controls.Add(ck_wholesale);
            Controls.Add(txt_barcodenumber);
            Controls.Add(check_barcode);
            Controls.Add(btn_save);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products Form";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn addedByDataGridViewTextBoxColumn;
        private Button btn_save;
        private CheckBox check_barcode;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextBox txt_barcodenumber;
        private CheckBox ck_wholesale;
        private TextBox txt_wholeSaleQuantity;
        private TextBox txt_productName;
        private TextBox txt_quantity;
        private TextBox txt_price;
        private TextBox txt_profit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_remove;
        private DataGridView dataGridView1;
        private BindingSource productViewModelBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewCheckBoxColumn isBarcodeDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn barcodeNumberDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isWholeSaleDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn wholeSaleQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private BindingSource productBindingSource1;
    }
}
