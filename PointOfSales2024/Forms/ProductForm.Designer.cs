﻿using System.Windows.Forms;

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
            productBindingSource = new BindingSource(components);
            productBindingSource1 = new BindingSource(components);
            txt_productName = new TextBox();
            txt_quantity = new TextBox();
            txt_price = new TextBox();
            productBindingSource2 = new BindingSource(components);
            productBindingSource3 = new BindingSource(components);
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
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AddedBy = new DataGridViewTextBoxColumn();
            dateAddedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productViewModelBindingSource = new BindingSource(components);
            btn_update = new Button();
            txt_search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.Cursor = Cursors.Hand;
            btn_save.Location = new Point(130, 182);
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
            check_barcode.Location = new Point(360, 29);
            check_barcode.Name = "check_barcode";
            check_barcode.Size = new Size(69, 19);
            check_barcode.TabIndex = 8;
            check_barcode.Text = "Barcode";
            check_barcode.UseVisualStyleBackColor = true;
            // 
            // txt_barcodenumber
            // 
            txt_barcodenumber.Location = new Point(130, 32);
            txt_barcodenumber.Name = "txt_barcodenumber";
            txt_barcodenumber.Size = new Size(224, 23);
            txt_barcodenumber.TabIndex = 0;
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
            txt_productName.Location = new Point(130, 65);
            txt_productName.Name = "txt_productName";
            txt_productName.Size = new Size(224, 23);
            txt_productName.TabIndex = 1;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(130, 101);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(224, 23);
            txt_quantity.TabIndex = 2;
            txt_quantity.KeyPress += txt_quantity_KeyPress;
            // 
            // txt_price
            // 
            txt_price.DataBindings.Add(new Binding("DataContext", productBindingSource2, "Price", true));
            txt_price.DataBindings.Add(new Binding("Text", productBindingSource3, "Price", true));
            txt_price.Location = new Point(130, 140);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(224, 23);
            txt_price.TabIndex = 3;
            txt_price.KeyPress += txt_price_KeyPress;
            // 
            // productBindingSource2
            // 
            productBindingSource2.DataSource = typeof(Models.Product);
            // 
            // productBindingSource3
            // 
            productBindingSource3.DataSource = typeof(Models.Product);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 32);
            label1.Name = "label1";
            label1.Size = new Size(111, 17);
            label1.TabIndex = 10;
            label1.Text = "Barcode Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 65);
            label3.Name = "label3";
            label3.Size = new Size(96, 17);
            label3.TabIndex = 12;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 101);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 12;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(80, 140);
            label5.Name = "label5";
            label5.Size = new Size(38, 17);
            label5.TabIndex = 12;
            label5.Text = "Price";
            // 
            // btn_remove
            // 
            btn_remove.Cursor = Cursors.Hand;
            btn_remove.Location = new Point(130, 260);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(224, 34);
            btn_remove.TabIndex = 6;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, isBarcodeDataGridViewCheckBoxColumn, barcodeNumberDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, AddedBy, dateAddedDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productViewModelBindingSource;
            dataGridView1.Location = new Point(12, 379);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(932, 286);
            dataGridView1.TabIndex = 7;
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
            // btn_update
            // 
            btn_update.Cursor = Cursors.Hand;
            btn_update.Location = new Point(130, 220);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(224, 34);
            btn_update.TabIndex = 5;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // txt_search
            // 
            txt_search.DataBindings.Add(new Binding("DataContext", productBindingSource2, "ProductName", true));
            txt_search.DataBindings.Add(new Binding("Text", productBindingSource3, "ProductName", true));
            txt_search.Location = new Point(13, 350);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Search";
            txt_search.Size = new Size(224, 23);
            txt_search.TabIndex = 13;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 677);
            Controls.Add(txt_search);
            Controls.Add(btn_update);
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
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products Form";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource3).EndInit();
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
        private TextBox txt_productName;
        private TextBox txt_quantity;
        private TextBox txt_price;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_remove;
        private DataGridView dataGridView1;
        private BindingSource productViewModelBindingSource;
        private DataGridViewCheckBoxColumn isWholeSaleDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn wholeSaleQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private BindingSource productBindingSource;
        private BindingSource productBindingSource1;
        private BindingSource productBindingSource2;
        private BindingSource productBindingSource3;
        private Button btn_update;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewCheckBoxColumn isBarcodeDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn barcodeNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn AddedBy;
        private DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private TextBox txt_search;
    }
}
