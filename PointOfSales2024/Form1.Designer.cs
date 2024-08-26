namespace PointOfSales2024
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            productBindingSource = new BindingSource(components);
            Id = new DataGridViewTextBoxColumn();
            isBarcodeDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            barcodeNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isWholeSaleDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            wholeSaleQuantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            profitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addedByDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateAddedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            appUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, isBarcodeDataGridViewCheckBoxColumn, barcodeNumberDataGridViewTextBoxColumn, isWholeSaleDataGridViewCheckBoxColumn, wholeSaleQuantityDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, profitDataGridViewTextBoxColumn, addedByDataGridViewTextBoxColumn, dateAddedDataGridViewTextBoxColumn, appUserDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(21, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(744, 554);
            dataGridView1.TabIndex = 0;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // isBarcodeDataGridViewCheckBoxColumn
            // 
            isBarcodeDataGridViewCheckBoxColumn.DataPropertyName = "IsBarcode";
            isBarcodeDataGridViewCheckBoxColumn.HeaderText = "IsBarcode";
            isBarcodeDataGridViewCheckBoxColumn.Name = "isBarcodeDataGridViewCheckBoxColumn";
            // 
            // barcodeNumberDataGridViewTextBoxColumn
            // 
            barcodeNumberDataGridViewTextBoxColumn.DataPropertyName = "BarcodeNumber";
            barcodeNumberDataGridViewTextBoxColumn.HeaderText = "BarcodeNumber";
            barcodeNumberDataGridViewTextBoxColumn.Name = "barcodeNumberDataGridViewTextBoxColumn";
            // 
            // isWholeSaleDataGridViewCheckBoxColumn
            // 
            isWholeSaleDataGridViewCheckBoxColumn.DataPropertyName = "IsWholeSale";
            isWholeSaleDataGridViewCheckBoxColumn.HeaderText = "IsWholeSale";
            isWholeSaleDataGridViewCheckBoxColumn.Name = "isWholeSaleDataGridViewCheckBoxColumn";
            // 
            // wholeSaleQuantityDataGridViewTextBoxColumn
            // 
            wholeSaleQuantityDataGridViewTextBoxColumn.DataPropertyName = "wholeSaleQuantity";
            wholeSaleQuantityDataGridViewTextBoxColumn.HeaderText = "wholeSaleQuantity";
            wholeSaleQuantityDataGridViewTextBoxColumn.Name = "wholeSaleQuantityDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // profitDataGridViewTextBoxColumn
            // 
            profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
            profitDataGridViewTextBoxColumn.HeaderText = "Profit";
            profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            // 
            // addedByDataGridViewTextBoxColumn
            // 
            addedByDataGridViewTextBoxColumn.DataPropertyName = "AddedBy";
            addedByDataGridViewTextBoxColumn.HeaderText = "AddedBy";
            addedByDataGridViewTextBoxColumn.Name = "addedByDataGridViewTextBoxColumn";
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            dateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded";
            dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            // 
            // appUserDataGridViewTextBoxColumn
            // 
            appUserDataGridViewTextBoxColumn.DataPropertyName = "AppUser";
            appUserDataGridViewTextBoxColumn.HeaderText = "AppUser";
            appUserDataGridViewTextBoxColumn.Name = "appUserDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 597);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewCheckBoxColumn isBarcodeDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn barcodeNumberDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isWholeSaleDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn wholeSaleQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addedByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn appUserDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
    }
}
