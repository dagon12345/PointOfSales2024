namespace PointOfSales2024.Popups
{
    partial class SearchProductPopUp
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
            dgSearch = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addedByDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateAddedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productViewModelBindingSource = new BindingSource(components);
            txt_search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgSearch
            // 
            dgSearch.AllowUserToAddRows = false;
            dgSearch.AllowUserToDeleteRows = false;
            dgSearch.AutoGenerateColumns = false;
            dgSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSearch.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, addedByDataGridViewTextBoxColumn, dateAddedDataGridViewTextBoxColumn });
            dgSearch.DataSource = productViewModelBindingSource;
            dgSearch.Location = new Point(12, 70);
            dgSearch.Name = "dgSearch";
            dgSearch.ReadOnly = true;
            dgSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSearch.Size = new Size(893, 477);
            dgSearch.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addedByDataGridViewTextBoxColumn
            // 
            addedByDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            addedByDataGridViewTextBoxColumn.DataPropertyName = "AddedBy";
            addedByDataGridViewTextBoxColumn.HeaderText = "AddedBy";
            addedByDataGridViewTextBoxColumn.Name = "addedByDataGridViewTextBoxColumn";
            addedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            dateAddedDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            dateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded";
            dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            dateAddedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productViewModelBindingSource
            // 
            productViewModelBindingSource.DataSource = typeof(ViewModel.ProductViewModel);
            // 
            // txt_search
            // 
            txt_search.Location = new Point(12, 29);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Search";
            txt_search.Size = new Size(893, 23);
            txt_search.TabIndex = 0;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // SearchProductPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 559);
            Controls.Add(txt_search);
            Controls.Add(dgSearch);
            MaximumSize = new Size(933, 598);
            MinimizeBox = false;
            Name = "SearchProductPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchProductPopUp";
            Load += SearchProductPopUp_Load;
            KeyDown += SearchProductPopUp_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)productViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgSearch;
        private TextBox txt_search;
        private BindingSource productViewModelBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addedByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
    }
}