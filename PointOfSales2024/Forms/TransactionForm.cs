using Microsoft.EntityFrameworkCore;
using PointOfSales2024.Data;
using PointOfSales2024.Models;
using PointOfSales2024.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSales2024.Forms
{
    public partial class TransactionForm : Form
    {
        private PosContext _dbContext;
        public TransactionForm()
        {
            InitializeComponent();
            _dbContext = new PosContext();
            txtCash.ShortcutsEnabled = true;


        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //await listOfProducts();
        }
        private void Formula()
        {
            try
            {
                double price = Convert.ToDouble(txtPrice.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                double overallPrice = price * quantity;
                txtOverallPrice.Text = overallPrice.ToString("f2"); //Convert it to decimal points



            }
            catch (Exception)
            {

                //throw;
            }


        }
        private void cashAndChangeFormula()
        {
            try
            {
                double overallTotal = Convert.ToDouble(txtOverallTotal.Text);
                double cash = Convert.ToDouble(txtCash.Text);
                double change = cash - overallTotal;
                txtChange.Text = change.ToString("F2"); //Conver it to decimal points.

            }
            catch (Exception)
            {

                // throw;
            }
        }
        private void clickButton()
        {
            btnEnter.PerformClick();
        }
        public void ClearFields()
        {
            txtBarcode.Clear();
            txtProductName.Text = "";
            txtQuantity.Text = "1";
            txtPrice.Text = "0.0";
            txtOverallPrice.Text = "0.0";
            txtBarcode.Focus();
            dataGridView1.ClearSelection();
        }
        public void overallTotalFormula()
        {

            double overallTotal = 0;
            //Iterate over all rows in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //Ensure the row is not a new row(used for adding new rows)
                if (!row.IsNewRow)
                {
                    //Retrieve the value frm the "OverallPrice" column and add it to the total
                    double cellValue;
                    if (double.TryParse(row.Cells["OverallPrice"].Value?.ToString(), out cellValue))
                    {
                        overallTotal += cellValue;
                    }

                }
            }
            //Display the total in txtOverallPrice.
            txtOverallTotal.Text = overallTotal.ToString("f2"); // Format to 2 decimal places
        }
        //public async Task listOfProducts()
        //{
        //    var selectedProducts = await _dbContext.Products
        //        .AsNoTracking()
        //        .ToListAsync();

        //    foreach (var selectedProduct in selectedProducts)
        //    {
        //        txtProductName.Items.Add(new Product
        //        {
        //            Id = selectedProduct.Id,
        //            ProductName = selectedProduct.ProductName
        //        });
        //    }


        //}
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//Only handled numbers
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            Formula();
            cashAndChangeFormula();
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            Formula();
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                txtQuantity.Text = "1";
            }
            Formula();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("There is no product scanned. Scan/Enter Product name to continue.", "No product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBarcode.Focus();// If error presist then focus the barcode.
                return;
            }
            var newOrderViewModel = new OrderViewModel
            {

                Barcode = txtBarcode.Text,
                ProductName = txtProductName.Text,
                Quantity = Convert.ToInt32(txtQuantity.Text),
                Price = Convert.ToDouble(txtPrice.Text),
                OverallPrice = Convert.ToDouble(txtOverallPrice.Text)
            };

            orderViewModelBindingSource.Add(newOrderViewModel);

            ClearFields();
            overallTotalFormula();

        }

        private void txtProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtProductName_KeyUp(object sender, KeyEventArgs e)
        {
            var textFilter = txtProductName.Text.ToLower();

            var searchedBarcode = _dbContext.Products
                                            .Where(x => x.ProductName.ToLower().Equals(textFilter))
                                            .ToList();
            var filteredOrderViewModel = searchedBarcode.Select(p => new OrderViewModel
            {

                Barcode = p.BarcodeNumber,
                ProductName = p.ProductName,
                Quantity = p.Quantity,
                Price = p.Price,

            }).ToList();



            foreach (var orderViewModel in filteredOrderViewModel)
            {
                txtBarcode.Text = orderViewModel.Barcode;
                txtProductName.Text = orderViewModel.ProductName;
                txtPrice.Text = orderViewModel.Price.ToString("f2");


            }

            Formula();

        }

        private void txtBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            var textFilter = txtBarcode.Text.ToLower();

            var searchedBarcode = _dbContext.Products
                                            .Where(x => x.BarcodeNumber.ToLower().Equals(textFilter))
                                            .ToList();
            var filteredOrderViewModel = searchedBarcode.Select(p => new OrderViewModel
            {

                Barcode = p.BarcodeNumber,
                ProductName = p.ProductName,
                Quantity = p.Quantity,
                Price = p.Price,

            }).ToList();




            foreach (var orderViewModel in filteredOrderViewModel)
            {
                txtBarcode.Text = orderViewModel.Barcode;
                txtProductName.Text = orderViewModel.ProductName;
                txtPrice.Text = orderViewModel.Price.ToString("f2");

            }

            Formula();
            cashAndChangeFormula();

        }

        private void txtCash_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnTransact_Click(object sender, EventArgs e)
        {
            double overallTotal = Convert.ToDouble(txtOverallTotal.Text);
            double cash = Convert.ToDouble(txtCash.Text);
            double change = cash - overallTotal;
            if (overallTotal > cash)
            {
                MessageBox.Show("Insufficient cash entered.","Insufficient",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else if( overallTotal == 0.0)
            {
                MessageBox.Show("No product has been punched. Please scan a product first then continue", "Scan a product first", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("I am pressed!");
        }

        private void txtCash_KeyUp(object sender, KeyEventArgs e)
        {
            cashAndChangeFormula();
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only handled numbers with decimals
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void txtCash_Leave(object sender, EventArgs e)
        {
            if (txtCash.Text == "")
            {
                txtCash.Text = "0.0";
            }
            cashAndChangeFormula();
        }

        private void txtOverallTotal_KeyUp(object sender, KeyEventArgs e)
        {
            cashAndChangeFormula();
        }
    }
}
