using Microsoft.EntityFrameworkCore;
using PointOfSales2024.Data;
using PointOfSales2024.Models;
using PointOfSales2024.ViewModel;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Interactivity;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PointOfSales2024
{
    public partial class ProductForm : Form
    {
        private PosContext _dbContext;
        private Product? _product;
        public ProductForm()
        {
            InitializeComponent();
            txt_barcodenumber.Focus();
        }


        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _dbContext = new PosContext();

            using (var context = new PosContext())
            {
                // Ensure the database is created
                //await context.Database.EnsureDeletedAsync();
                await context.Database.EnsureCreatedAsync();


                // Load the products from the database, including the related AppUser data
                var products = await _dbContext.Products
                    .Include(p => p.AppUser)  // Include related data
                    .AsNoTracking()
                    .ToListAsync();


                // Map Product objects to ProductViewModel objects
                var productViewModels = products.Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    IsBarcode = p.IsBarcode,
                    BarcodeNumber = p.BarcodeNumber,
                    ProductName = p.ProductName,
                    Quantity = p.Quantity,
                    Price = p.Price,
                    //Profit = p.Profit,
                    AddedBy = p.AppUser.Name,  // Get the name of the associated AppUser
                    DateAdded = p.DateAdded

                }).ToList();

                // Bind the product list to the DataGridView
                dataGridView1.DataSource = productViewModels;
                //dataGridView1.DataSource = productViewModelBindingSource;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_productName.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }


            try
            {
                // Create a new Product if _product is not initialized
                _product = new Product
                {
                    IsBarcode = check_barcode.Checked,
                    BarcodeNumber = txt_barcodenumber.Text,
                    ProductName = txt_productName.Text,
                    Quantity = Convert.ToInt32(txt_quantity.Text),
                    Price = Convert.ToDouble(txt_price.Text),
                    //Profit = Convert.ToDouble(txt_profit.Text),
                    AppUserId = 1, // or get this dynamically
                    DateAdded = DateTime.Now
                };

                _dbContext.Products.Add(_product); // Add the new product to the context
                _dbContext.SaveChanges(); // Save changes to the database
                                          // Optionally refresh the DataGridView
                OnLoad(EventArgs.Empty);
                ClearFields();
                MessageBox.Show("Product saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            check_barcode.Checked = true;
            txt_barcodenumber.Clear();
            txt_productName.Clear();
            txt_quantity.Clear();
            txt_price.Clear();
            txt_price.Clear();
            txt_barcodenumber.Focus();
            btn_save.Text = "Save";


        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Empty table.");
                return;
            }
            if (txt_productName.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }


            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int selectedProductId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                _dbContext.Remove(_dbContext.Products.Single(x => x.Id == selectedProductId));
                _dbContext.SaveChanges();
                // Optionally refresh the DataGridView
                OnLoad(EventArgs.Empty);
                ClearFields();
                MessageBox.Show("Record Deleted Successfully");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            // Get the product ID from the selected row
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Empty table.");
                return;
            }


            int selectedProductId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            _product = _dbContext.Products
                .Include(p => p.AppUser) // Include related data if needed
                .FirstOrDefault(x => x.Id == selectedProductId);
            // Populate the form controls with the product details
            check_barcode.Checked = _product.IsBarcode;
            txt_barcodenumber.Text = _product.BarcodeNumber ?? string.Empty;
            // ck_wholesale.Checked = _product.IsWholeSale;
            // txt_wholeSaleQuantity.Text = _product.wholeSaleQuantity.ToString();
            txt_productName.Text = _product.ProductName;
            txt_quantity.Text = _product.Quantity.ToString();
            txt_price.Text = _product.Price.ToString();


        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//Only handled numbers
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//Only handled numbers
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Empty table.");
                return;
            }
            if (txt_productName.Text == "")
            {
                MessageBox.Show("Select what you want to update");
                return;
            }


            int selectedProductId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            var product = _dbContext.Products.First(a => a.Id == selectedProductId);

            // Update existing product

            product.IsBarcode = check_barcode.Checked;
            product.BarcodeNumber = txt_barcodenumber.Text;
            product.ProductName = txt_productName.Text;
            product.Quantity = Convert.ToInt32(txt_quantity.Text);
            product.Price = Convert.ToDouble(txt_price.Text);
            // _product.Profit = Convert.ToDouble(txt_profit.Text);
            product.AppUserId = 1;
            product.DateAdded = DateTime.Now;

            _dbContext.Products.Update(product); // Mark the product as updated
            _dbContext.SaveChanges();
            OnLoad(EventArgs.Empty);
            ClearFields();
            MessageBox.Show("Record updated Successfully");

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var textfilter = txt_search.Text.ToLower();
            // Assuming Products is a DbSet in your _dbContext and you're using DataGridView named dgvProducts
            var filteredProducts = _dbContext.Products
                                             .Where(s => s.ProductName.ToLower().Contains(textfilter) || s.BarcodeNumber.ToLower().Contains(textfilter))
                                             .ToList();

            // Bind filtered data to DataGridView
            dataGridView1.DataSource = filteredProducts;
        }
    }
}

