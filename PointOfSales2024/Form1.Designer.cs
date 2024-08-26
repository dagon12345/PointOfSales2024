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
            dataGridView1 = new DataGridView();
            btn_save = new Button();
            check_barcode = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(94, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(591, 318);
            dataGridView1.TabIndex = 0;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(94, 477);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(164, 46);
            btn_save.TabIndex = 1;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // check_barcode
            // 
            check_barcode.AutoSize = true;
            check_barcode.Checked = true;
            check_barcode.CheckState = CheckState.Checked;
            check_barcode.Location = new Point(108, 45);
            check_barcode.Name = "check_barcode";
            check_barcode.Size = new Size(69, 19);
            check_barcode.TabIndex = 2;
            check_barcode.Text = "Barcode";
            check_barcode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 597);
            Controls.Add(check_barcode);
            Controls.Add(btn_save);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            //Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn addedByDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private Button btn_save;
        private CheckBox check_barcode;
    }
}
