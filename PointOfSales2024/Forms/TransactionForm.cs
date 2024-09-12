using PointOfSales2024.Data;
using PointOfSales2024.Models;
using PointOfSales2024.Popups;
using PointOfSales2024.ViewModel;
using System;
using System.Data;
using System.Drawing.Printing;

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
            this.KeyPreview = true;
            this.KeyDown += txtBarcode_KeyDown;
            this.KeyDown += txtCash_KeyDown;
            this.KeyDown += txtQuantity_KeyDown;
            this.KeyDown += btnTransact_KeyDown;
            searchProductToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;


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
            // Check if Ctrl+C is pressed
            if ((e.Control && e.KeyCode == Keys.C))
            {
                //Focus the cash text
                txtCash.Focus();
            }

        }

        private void printReceipt()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            // You can show a Print Dialog if needed:
            PrintDialog printDialog = new PrintDialog();
            //if (printDialog.ShowDialog() == DialogResult.OK)
            //{
            //    printDocument.Print();  // trigger printing
            //}
            //else
           // {
           if(checkBox1.Checked)
            {
                printDocument.Print();
            }

               // Automatically trigger printing without dialog if you prefer
            //}
        }

        private string[] SplitStringToLines(string text, Font font, float maxWidth, Graphics g)
        {
            List<string> lines = new List<string>();
            string[] words = text.Split(' ');

            string currentLine = "";
            foreach (string word in words)
            {
                // Measure the current line with the new word added
                string testLine = currentLine.Length > 0 ? currentLine + " " + word : word;
                SizeF textSize = g.MeasureString(testLine, font);

                // If adding the new word exceeds the max width, commit the current line and start a new one
                if (textSize.Width > maxWidth)
                {
                    lines.Add(currentLine);
                    currentLine = word;  // Start a new line with the current word
                }
                else
                {
                    currentLine = testLine;  // Add the word to the current line
                }
            }

            // Add the last line
            if (currentLine.Length > 0)
            {
                lines.Add(currentLine);
            }

            return lines.ToArray();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Define font, alignment, and margin variables for your receipt
            Font font = new Font("Courier New", 7);  // Smaller fixed-width font for better fit
            Font boldFont = new Font("Courier New", 8, FontStyle.Bold); // Slightly larger for headings
            float lineHeight = font.GetHeight();
            float startX = 4;  // Adjusted left margin
            float startY = 5;   // Small top margin
            float offsetY = 0;
            float maxWidth = 190;  // Max width in pixels for 56mm paper (about 200px total width minus margins)
            float paperWidth = 190;  // Approximate width for 56mm paper in pixels

            // Print receipt header
            e.Graphics.DrawString("A. Bracquene's", boldFont, Brushes.Black, startX, startY + offsetY);
            offsetY += lineHeight;  // Add some space
            e.Graphics.DrawString("Sari-Sari Store", boldFont, Brushes.Black, startX, startY + offsetY);
            offsetY += lineHeight;  // Add some space
            e.Graphics.DrawString("Store Owner:", font, Brushes.Black, startX, startY + offsetY);
            offsetY += lineHeight;  // Add some space
            e.Graphics.DrawString("Maria Fe Cortes Urquia", boldFont, Brushes.Black, startX, startY + offsetY);
            offsetY += lineHeight;  // Add some space
            e.Graphics.DrawString("** Not an official receipt **", font, Brushes.Black, startX, startY + offsetY);
            offsetY += lineHeight * 2;  // Add some space

            // Print transaction date
            e.Graphics.DrawString("Transaction Date:", font, Brushes.Black, startX, startY + offsetY);
            offsetY += lineHeight;
            e.Graphics.DrawString(DateTime.Now.ToString("MMM dd, yyyy hh:mm tt"), font, Brushes.Black, startX, startY + offsetY);
            offsetY += lineHeight * 2;

            // Print column headers (Qty, Product, Price)
            float qtyWidth = 25;  // Width for Qty
            float priceWidth = 40;  // Width for Price
            //float totalWidth = 50;  // Width for Total

            e.Graphics.DrawString("Qty", boldFont, Brushes.Black, startX + 10 , startY + offsetY);  // Qty header
            //e.Graphics.DrawString("Product", boldFont, Brushes.Black, startX + qtyWidth + 5, startY + offsetY);  // Product header
            e.Graphics.DrawString("Price", boldFont, Brushes.Black, startX + 10 + qtyWidth, startY + offsetY);  // Price header
            e.Graphics.DrawString("Total", boldFont, Brushes.Black, startX + 10 + qtyWidth + priceWidth, startY + offsetY);  // Total header
            offsetY += lineHeight * 2;

            // Loop through the DataGridView rows and print each item
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var row = dataGridView1.Rows[i];

                // Get the product name, quantity, price, and overall price
                string productName = row.Cells["ProductName"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                double price = Convert.ToDouble(row.Cells["Price"].Value);
                double overallPrice = Convert.ToDouble(row.Cells["OverallPrice"].Value);

                // Print the product name in the first row
                string[] productNameLines = SplitStringToLines(productName, font, maxWidth, e.Graphics);  // Break into multiple lines if necessary
                foreach (string line in productNameLines)
                {
                    e.Graphics.DrawString(line, font, Brushes.Black, startX, startY + offsetY);  // Print product name in full width
                    offsetY += lineHeight;  // Move to the next line for wrapped text
                }

                // Print the details in the second row: Quantity, Price, Overall Price
                float detailOffsetX = startX + 10;  // Adjusted offset to move text 5 pixels to the right
                string details = $"{quantity} x {price:F2} = {overallPrice:F2}";
                e.Graphics.DrawString(details, font, Brushes.Black, detailOffsetX, startY + offsetY);
                offsetY += lineHeight * 2;  // Add space after each item

            }

            // Print totals
            e.Graphics.DrawString("Amount Due: " + txtOverallTotal.Text, boldFont, Brushes.Black, startX, startY + offsetY);
            offsetY += lineHeight;
            e.Graphics.DrawString("Amount Tendered: " + txtCash.Text, boldFont, Brushes.Black, startX, startY + offsetY);
            offsetY += lineHeight;
            e.Graphics.DrawString("Change: " + (Convert.ToDouble(txtCash.Text) - Convert.ToDouble(txtOverallTotal.Text)).ToString("F2"), boldFont, Brushes.Black, startX, startY + offsetY);

            // Add footer "Thank you, come again!" centered
            offsetY += lineHeight * 2;
            string footerText = "Thank you. Come again!";
            float footerTextWidth = e.Graphics.MeasureString(footerText, font).Width;
            float footerX = (paperWidth - footerTextWidth) / 2;  // Center the text

            e.Graphics.DrawString(footerText, font, Brushes.Black, footerX, startY + offsetY);

            // Indicate that more pages are not needed
            e.HasMorePages = false;
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

                        //Minus the quantity ordered into our products
                        var productReturnStock = _dbContext.Products.Find(orderProductId);
                        productReturnStock.Quantity -= quantity;

                        // _dbContext.SaveChanges();



                    }
                    // Save all changes to the database at once.
                    _dbContext.SaveChanges();
                    printReceipt();//Printing or receipt
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

        //Open form and prevent the form from opening again once the instance is not null.

        SearchProductPopUp searchProductPopup;
        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SearchProductPopUp>().Any())
            {
                searchProductPopup.Select();
                searchProductPopup.BringToFront();
            }
            else
            {
                searchProductPopup = new SearchProductPopUp();
                searchProductPopup.ShowDialog();

            }
        }

        private void TransactionForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
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

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Ctrl+B is pressed
            if ((e.Control && e.KeyCode == Keys.B))
            {
                //Focus the txtBarcode
                txtBarcode.Focus();
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Ctrl+Q is pressed
            if ((e.Control && e.KeyCode == Keys.Q))
            {
                //Focus the txtQuantity
                txtQuantity.Focus();
            }
        }

        private void btnTransact_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control && e.KeyCode == Keys.T))
            {
                btnTransact.PerformClick();
            }

        }
    }
}
