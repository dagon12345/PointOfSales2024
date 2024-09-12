using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using PointOfSales2024.Data;
using PointOfSales2024.ViewModel;
using System.Data;
using System.Windows.Forms;

namespace PointOfSales2024.Forms
{
    public partial class AddedStocksForm : Form
    {
        public AddedStocksForm()
        {
            InitializeComponent();
        }

        private async void AddedStocksForm_Load(object sender, EventArgs e)
        {
           // await DisplayAddedStocks();
        }



     

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dtFrom.Value.Date;
            DateTime dateTo = dtTo.Value.Date;
            //We used using statement so that after searching it will be disposed properly.
            using (var context = new PosContext())
            {
                var searchAddedStocks = await context.AddedStocks
                .Include(a => a.AppUser)
                .Include(p => p.Product)
                .Where(d => d.DateAdded.Date >= dateFrom && d.DateAdded.Date <= dateTo) //  Search between dates using EF core.
                .OrderByDescending(i => i.Id)
                .AsNoTracking()
                .ToListAsync();

                var addedStocksViewModel = searchAddedStocks.Select(o => new AddedStocksViewModel
                {
                    Id = o.Id,  
                    ProductId = o.ProductId,
                    BarcodeNumber = o.Product.BarcodeNumber,
                    ProductName = o.Product.ProductName,
                    Price = o.Product.Price,
                    AddedBy = o.AppUser.Name,
                    QuantityAdded = o.Quantity,
                    DateAdded = o.DateAdded


                }).ToList();



                addedStocksViewModelBindingSource.DataSource = addedStocksViewModel;
                dgAddedStocks.DataSource = addedStocksViewModelBindingSource;


                dgAddedStocks.Columns["Price"].DefaultCellStyle.Format = "C2";
                dgAddedStocks.Columns["Price"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");

                //Calculate the total of OverallPrice
                double totalQuantity = 0;
                foreach (DataGridViewRow row in dgAddedStocks.Rows)
                {
                    if (row.Cells["QuantityAdded"].Value != null)
                    {
                        totalQuantity += Convert.ToInt32(row.Cells["QuantityAdded"].Value);
                    }
                }

                //Display the total into our label
                lblQuantity.Text = $"Total Quantity Added: {totalQuantity}";



                if (dgAddedStocks.Rows.Count == 0)
                {
                    MessageBox.Show("There is nothing to be exported", "Empty table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Saving excel below
                else if (MessageBox.Show("Do you want to export this to excel?", "Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Set the license context (NonCommercial is free for non-commercial use)
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        // Export to Excel
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = $"Added Stocks Report";
                        saveFileDialog.FileName = $"Added stocks span of {dtFrom.Value.ToString("MMM-dd-yyyy")} to {dtTo.Value.ToString("MMM-dd-yyyy")}.";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Get the selected file path
                            string filePath = saveFileDialog.FileName;


                            using (var package = new ExcelPackage())
                            {
                                var worksheet = package.Workbook.Worksheets.Add("AddedStocksReport");

                                // Add headers
                                // worksheet.Cells[1, 1].Value = "Order ID";
                                worksheet.Cells[1, 1].Value = "BarcodeNumber";
                                worksheet.Cells[1, 2].Value = "ProductName";
                                worksheet.Cells[1, 3].Value = "Price";
                                worksheet.Cells[1, 4].Value = "AddedBy";
                                worksheet.Cells[1, 5].Value = "QuantityAdded";
                                worksheet.Cells[1, 6].Value = "DateAdded";

                                // Add data
                                for (int i = 0; i < addedStocksViewModel.Count; i++)
                                {
                                    var sale = addedStocksViewModel[i];
                                    //worksheet.Cells[i + 2, 1].Value = sale.OrderId;
                                    worksheet.Cells[i + 2, 1].Value = sale.BarcodeNumber;
                                    worksheet.Cells[i + 2, 2].Value = sale.ProductName;
                                    worksheet.Cells[i + 2, 3].Value = sale.Price;
                                    worksheet.Cells[i + 2, 4].Value = sale.AddedBy;
                                    worksheet.Cells[i + 2, 5].Value = sale.QuantityAdded;
                                    worksheet.Cells[i + 2, 6].Value = sale.DateAdded.ToString("yyyy-MM-dd HH:mm:ss");
                                }

                                // Add total sales row
                                int totalRow = addedStocksViewModel.Count + 2;
                                worksheet.Cells[totalRow, 4].Value = "Total Stocks Added:";
                                worksheet.Cells[totalRow, 5].Value = totalQuantity.ToString();

                                // Format the total row
                                worksheet.Cells[totalRow, 4, totalRow, 5].Style.Font.Bold = true;
                                // worksheet.Cells[totalRow, 6].Style.Numberformat.Format = "₱#,##0.00";

                                // Auto-fit columns
                                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                                // Save the Excel file
                                var excelFile = new FileInfo(filePath);
                                package.SaveAs(excelFile);
                            }

                            MessageBox.Show("Added Stocks report exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }


                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgAddedStocks.Rows.Count == 0)
            {
                MessageBox.Show("Empty table.");
                return;
            }


            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                var selectedProduct = addedStocksViewModelBindingSource.Current as AddedStocksViewModel;

                using (var context = new PosContext())
                {
                    var addedStocksDelete = context.AddedStocks.Find(selectedProduct.Id);
                    if (addedStocksDelete != null)
                    {
                       
                        context.AddedStocks.Remove(addedStocksDelete);
                        context.SaveChanges();

                      
                        int selectedProductId = Convert.ToInt32(dgAddedStocks.CurrentRow.Cells["ProductId"].Value);
                        var productMinusStock = context.Products.Find(selectedProductId);
                        if (productMinusStock != null)
                        {
                            productMinusStock.Quantity -= addedStocksDelete.Quantity;
                            context.SaveChanges();

                            MessageBox.Show("Particular added product removed successfully. Quantity is deducted back to to product quantity.","Deducted",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Product not found.");
                        }

                        addedStocksViewModelBindingSource.Remove(selectedProduct);
                    }
                    else
                    {
                        MessageBox.Show("Order not found.");
                    }
                }


            }
        }
    }
}
