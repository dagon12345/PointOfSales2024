﻿namespace PointOfSales2024.Forms
{
    partial class DashboardForm
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
            btnAddproduct = new Button();
            btnAddStocks = new Button();
            btnTransact = new Button();
            SuspendLayout();
            // 
            // btnAddproduct
            // 
            btnAddproduct.Cursor = Cursors.Hand;
            btnAddproduct.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddproduct.Location = new Point(12, 160);
            btnAddproduct.Name = "btnAddproduct";
            btnAddproduct.Size = new Size(282, 105);
            btnAddproduct.TabIndex = 0;
            btnAddproduct.Text = "Add Product";
            btnAddproduct.UseVisualStyleBackColor = true;
            btnAddproduct.Click += btnAddproduct_Click;
            // 
            // btnAddStocks
            // 
            btnAddStocks.Cursor = Cursors.Hand;
            btnAddStocks.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddStocks.Location = new Point(12, 282);
            btnAddStocks.Name = "btnAddStocks";
            btnAddStocks.Size = new Size(282, 105);
            btnAddStocks.TabIndex = 0;
            btnAddStocks.Text = "Add Stocks";
            btnAddStocks.UseVisualStyleBackColor = true;
            // 
            // btnTransact
            // 
            btnTransact.Cursor = Cursors.Hand;
            btnTransact.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransact.Location = new Point(12, 404);
            btnTransact.Name = "btnTransact";
            btnTransact.Size = new Size(282, 105);
            btnTransact.TabIndex = 0;
            btnTransact.Text = "Transact";
            btnTransact.UseVisualStyleBackColor = true;
            btnTransact.Click += btnTransact_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 668);
            Controls.Add(btnTransact);
            Controls.Add(btnAddStocks);
            Controls.Add(btnAddproduct);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddproduct;
        private Button btnAddStocks;
        private Button btnTransact;
    }
}