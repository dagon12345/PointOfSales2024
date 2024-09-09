using PointOfSales2024.Data;
using PointOfSales2024.Models;
using PointOfSales2024.ViewModel;
using System.Data;

namespace PointOfSales2024.Forms
{
    public partial class TransactionForm : Form
    {
        private PosContext _dbContext;
        private Order _order;
        public TransactionForm()
        {
            InitializeComponent();
            _dbContext = new PosContext();
            txtCash.ShortcutsEnabled = true;


        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }
        public void ClearTransactions()
        {
            txtOverallTotal.Text = "0.0";
            txtCash.Text = "0.0";
            txtChange.Text = "0.0";

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
            lblProductId.Text = "0";
            lblNotification.Text = "Success";
            lblNotification.ForeColor = Color.SeaGreen;
            txtBarcode.Focus();
            dataGridView1.ClearSelection();
        }
        public void VoidFormula()
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

        private int _lastSortId = 0;

        private void SortIdCounter()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                //Get the highes SortId from existing rows
                _lastSortId = dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Max(row => Convert.ToInt32(row.Cells["Id"].Value));
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var textFilter = txtBarcode.Text.ToLower();

            var searchedBarcode = _dbContext.Products
                                            .Where(x => x.BarcodeNumber.ToLower().Equals(textFilter))
                                            .ToList();
            if (!searchedBarcode.Any())
            {
                ClearFields();
                lblNotification.Text = "Barcode does not exist";
                lblNotification.ForeColor = Color.Crimson;
                return;

            }

            int productId = Convert.ToInt32(lblProductId.Text);
            if (txtProductName.Text == "")
            {
                MessageBox.Show("There is no product scanned. Scan/Enter Product name to continue.", "No product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBarcode.Focus();// If error presist then focus the barcode.
                return;
            }

            //Increment _SortId
            _lastSortId++;
            var newOrderViewModel = new OrderViewModel
            {
                Id = _lastSortId,
                ProductId = productId,
                Barcode = txtBarcode.Text,
                ProductName = txtProductName.Text,
                Quantity = Convert.ToInt32(txtQuantity.Text),
                Price = Convert.ToDouble(txtPrice.Text),
                OverallPrice = Convert.ToDouble(txtOverallPrice.Text)
            };

            orderViewModelBindingSource.Add(newOrderViewModel);

            var sortedList = orderViewModelBindingSource.List.Cast<OrderViewModel>()
                .OrderByDescending(x => x.Id)
                .ToList();

            orderViewModelBindingSource.DataSource = sortedList;

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
                Id = p.Id,
                Barcode = p.BarcodeNumber,
                ProductName = p.ProductName,
                Quantity = p.Quantity,
                Price = p.Price,

            }).ToList();


            int productId = Convert.ToInt32(lblProductId.Text);
            foreach (var orderViewModel in filteredOrderViewModel)
            {
                productId = orderViewModel.Id;
                lblProductId.Text = productId.ToString();
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

                Id = p.Id,
                Barcode = p.BarcodeNumber,
                ProductName = p.ProductName,
                Quantity = p.Quantity,
                Price = p.Price,

            }).ToList();



            int productId = Convert.ToInt32(lblProductId.Text);
            foreach (var orderViewModel in filteredOrderViewModel)
            {
                //orderViewModel.Id = orderViewModel.Id;
                productId = orderViewModel.Id;
                lblProductId.Text = productId.ToString();
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

            try
            {
                if (txtCash.Text == "")
                {
                    txtCash.Text = "0.0";
                    MessageBox.Show("Insufficient cash entered.", "Insufficient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double overallTotal = Convert.ToDouble(txtOverallTotal.Text);
                double cash = Convert.ToDouble(txtCash.Text);
                double change = cash - overallTotal;
                Random orderId = new Random();
                int randomId = orderId.Next(100000, 999999);


                if (overallTotal > cash)
                {
                    MessageBox.Show("Insufficient cash entered.", "Insufficient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (overallTotal == 0.0)
                {
                    MessageBox.Show("No product has been punched. Please scan a product first then continue", "Scan a product first", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBarcode.Focus();
                    return;
                }

                if (MessageBox.Show("Are you sure you want to transact?", "Transact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //double cashOrder = Convert.ToDouble(txtCash.Text);
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        var row = dataGridView1.Rows[i];
                        //Extract values from the current row.

                        int orderProductId = Convert.ToInt32(row.Cells["ProductId"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        double orderOverallPrice = Convert.ToInt32(row.Cells["OverallPrice"].Value);

                        _order = new Order
                        {
                            OrderId = randomId,
                            ProductId = orderProductId,
                            OrderQuantity = quantity,
                            OverallPrice = orderOverallPrice,
                            Cash = cash,
                            AppUserId = 1,
                            DateTimeTransacted = DateTime.Now
                        };
                        //Add the order to the context
                        _dbContext.Orders.Add(_order);

                    }
                    // Save all changes to the database at once.
                    _dbContext.SaveChanges();

                    dataGridView1.Rows.Clear();
                    MessageBox.Show("Order transacted successfully", "Transacted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    ClearTransactions();
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void btnVoid_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There is nothing to void", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Are you sure you want to viod this item?", "Void", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selectedOrder = orderViewModelBindingSource.Current as OrderViewModel;
                orderViewModelBindingSource.Remove(selectedOrder);
                //Formula();
                VoidFormula();
                cashAndChangeFormula();
                MessageBox.Show("Voided successfully", "Voided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarcode.Focus();

            }


        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            txtBarcode.Focus();
        }
    }
}
