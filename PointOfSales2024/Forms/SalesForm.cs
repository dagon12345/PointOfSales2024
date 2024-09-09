using Microsoft.EntityFrameworkCore;
using PointOfSales2024.Data;
using PointOfSales2024.ViewModel;
using System.Data;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using System.Windows.Forms;

namespace PointOfSales2024.Forms
{
    public partial class SalesForm : Form
    {

        private PosContext _dbContext;

        public SalesForm()
        {
            InitializeComponent();


        }

        private void SalesForm_Load(object sender, EventArgs e)
        {

        }
        public void Formula()
        {
            double totalSales = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["OverallPrice"].Value != null)
                {
                    totalSales += Convert.ToDouble(row.Cells["OverallPrice"].Value);
                }
            }

            //Display the total into our label
            lbltotalSales.Text = $"Total Sales: {totalSales.ToString("C2", new System.Globalization.CultureInfo("en-PH"))}";
        }


        private async void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dtFrom.Value.Date;
            DateTime dateTo = dtTo.Value.Date;
            //We used using statement so that after searching it will be disposed properly.
            using (var context = new PosContext())
            {
                var searchSales = await context.Orders
                .Include(a => a.AppUser)
                .Include(p => p.Product)
                .Where(d => d.DateTimeTransacted.Date >= dateFrom && d.DateTimeTransacted.Date <= dateTo) //  Search between dates using EF core.
                .OrderByDescending(i => i.Id)
                .AsNoTracking()
                .ToListAsync();

                var salesViewModel = searchSales.Select(o => new SalesViewModel
                {
                    Id = o.Id,
                    OrderId = o.OrderId,
                    ProductName = o.Product.ProductName,
                    ProductBarcode = o.Product.BarcodeNumber,
                    Price = o.Product.Price,
                    OrderQuantity = o.OrderQuantity,
                    OverallPrice = o.OverallPrice,
                    TransactedBy = o.AppUser.Name,
                    DateTimeTransacted = o.DateTimeTransacted,
                    Cash = o.Cash,


                }).ToList();



                salesViewModelBindingSource.DataSource = salesViewModel;
                dataGridView1.DataSource = salesViewModelBindingSource;


                dataGridView1.Columns["Price"].DefaultCellStyle.Format = "C2";
                dataGridView1.Columns["Price"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");
                dataGridView1.Columns["OverallPrice"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");
                dataGridView1.Columns["Cash"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");

                //Calculate the total of OverallPrice
                double totalSales = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["OverallPrice"].Value != null)
                    {
                        totalSales += Convert.ToDouble(row.Cells["OverallPrice"].Value);
                    }
                }

                //Display the total into our label
                lbltotalSales.Text = $"Total Sales: {totalSales.ToString("C2", new System.Globalization.CultureInfo("en-PH"))}";



                if (dataGridView1.Rows.Count == 0)
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
                        saveFileDialog.Title = $"Save Sales Report";
                        saveFileDialog.FileName = $"Sales span of {dtFrom.Value.ToString("MMM-dd-yyyy")} to {dtTo.Value.ToString("MMM-dd-yyyy")}.";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Get the selected file path
                            string filePath = saveFileDialog.FileName;


                            using (var package = new ExcelPackage())
                            {
                                var worksheet = package.Workbook.Worksheets.Add("SalesReport");

                                // Add headers
                                worksheet.Cells[1, 1].Value = "Order ID";
                                worksheet.Cells[1, 2].Value = "Product Name";
                                worksheet.Cells[1, 3].Value = "Product Barcode";
                                worksheet.Cells[1, 4].Value = "Price";
                                worksheet.Cells[1, 5].Value = "Order Quantity";
                                worksheet.Cells[1, 6].Value = "Overall Price";
                                worksheet.Cells[1, 7].Value = "Transacted By";
                                worksheet.Cells[1, 8].Value = "DateTime Transacted";
                                worksheet.Cells[1, 9].Value = "Cash";

                                // Add data
                                for (int i = 0; i < salesViewModel.Count; i++)
                                {
                                    var sale = salesViewModel[i];
                                    worksheet.Cells[i + 2, 1].Value = sale.OrderId;
                                    worksheet.Cells[i + 2, 2].Value = sale.ProductName;
                                    worksheet.Cells[i + 2, 3].Value = sale.ProductBarcode;
                                    worksheet.Cells[i + 2, 4].Value = sale.Price;
                                    worksheet.Cells[i + 2, 5].Value = sale.OrderQuantity;
                                    worksheet.Cells[i + 2, 6].Value = sale.OverallPrice;
                                    worksheet.Cells[i + 2, 7].Value = sale.TransactedBy;
                                    worksheet.Cells[i + 2, 8].Value = sale.DateTimeTransacted.ToString("yyyy-MM-dd HH:mm:ss");
                                    worksheet.Cells[i + 2, 9].Value = sale.Cash;
                                }

                                // Add total sales row
                                int totalRow = salesViewModel.Count + 2;
                                worksheet.Cells[totalRow, 5].Value = "Total Sales:";
                                worksheet.Cells[totalRow, 6].Value = totalSales.ToString("C2", new System.Globalization.CultureInfo("en-PH"));

                                // Format the total row
                                worksheet.Cells[totalRow, 5, totalRow, 6].Style.Font.Bold = true;
                                worksheet.Cells[totalRow, 6].Style.Numberformat.Format = "₱#,##0.00";

                                // Auto-fit columns
                                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                                // Save the Excel file
                                var excelFile = new FileInfo(filePath);
                                package.SaveAs(excelFile);
                            }

                            MessageBox.Show("Sales report exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }


                }

            }


        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Empty table.");
                return;
            }


            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                var selectedProduct = salesViewModelBindingSource.Current as SalesViewModel;

                if (selectedProduct != null)
                {
                    using(var context = new PosContext())
                    {
                        // Delete the product from the database
                        var productToDelete = context.Orders.Find(selectedProduct.Id);
                        context.Orders.Remove(productToDelete);
                        context.SaveChanges();

                        // Remove the product from the BindingSource
                        salesViewModelBindingSource.Remove(selectedProduct);
                        dataGridView1.Refresh();
                        MessageBox.Show("Transaction deleted sucessfully.");
                        Formula();
                    }
                  
                }

            }
        }
    }
}
