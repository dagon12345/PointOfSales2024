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
            dgSearch = new DataGridView();
            txt_search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgSearch).BeginInit();
            SuspendLayout();
            // 
            // dgSearch
            // 
            dgSearch.AllowUserToAddRows = false;
            dgSearch.AllowUserToDeleteRows = false;
            dgSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSearch.Location = new Point(12, 70);
            dgSearch.Name = "dgSearch";
            dgSearch.ReadOnly = true;
            dgSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSearch.Size = new Size(893, 477);
            dgSearch.TabIndex = 8;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(12, 29);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Search";
            txt_search.Size = new Size(893, 23);
            txt_search.TabIndex = 14;
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
            ((System.ComponentModel.ISupportInitialize)dgSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgSearch;
        private TextBox txt_search;
    }
}