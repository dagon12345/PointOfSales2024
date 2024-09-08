using Microsoft.EntityFrameworkCore;
using PointOfSales2024.Data;
using PointOfSales2024.Models;
using PointOfSales2024.ViewModel;
using System.ComponentModel;
using System.Data;

namespace PointOfSales2024
{
    public partial class ProductForm : Form
    {
        private PosContext _dbContext;
        private Product? _product;
        private ProductViewModel _productViewModel;
        public ProductForm()
        {
            InitializeComponent();
            txt_barcodenumber.Focus();
        }



        //private BindingList<ProductViewModel> list = new BindingList<ProductViewModel>();

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _dbContext = new PosContext();

            using (var context = new PosContext())
            {

                // Ensure the database is created
                // await context.Database.EnsureDeletedAsync();
                await context.Database.EnsureCreatedAsync();

                // Load the products from the database, including the related AppUser data
                var products = await _dbContext.Products
                    .Include(p => p.AppUser)  // Include related data
                                              //.AsNoTracking()
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
                productViewModelBindingSource.DataSource = productViewModels;
                dataGridView1.DataSource = productViewModelBindingSource;
                dataGridView1.ClearSelection();
            }
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            /*Instead of getting data from database, we used the refresh grid same reflected as what we've added 
             into our database.*/
            if (txt_productName.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }


            _product = new Product
            {
                IsBarcode = check_barcode.Checked,
                BarcodeNumber = txt_barcodenumber.Text,
                ProductName = txt_productName.Text,
                Quantity = Convert.ToInt32(txt_quantity.Text),
                Price = Convert.ToDouble(txt_price.Text),
                //Profit = Convert.ToDouble(txt_profit.Text),
                AppUserId = 1, // or get this dynamically/ we will use this later when we create login
                DateAdded = DateTime.Now
            };

            _dbContext.Products.Add(_product); // Add the new product to the context
            _dbContext.SaveChanges(); // Save changes to the database


            // Add the new product to the BindingSource
            var newProductViewModel = new ProductViewModel
            {
                Id = _product.Id,
                IsBarcode = _product.IsBarcode,
                BarcodeNumber = _product.BarcodeNumber,
                ProductName = _product.ProductName,
                Quantity = _product.Quantity,
                Price = _product.Price,
                AddedBy = "User Name",  // replace with actual user name/ we will use this later when we create login
                DateAdded = _product.DateAdded
            };

            productViewModelBindingSource.Add(newProductViewModel);
            ClearFields();
            MessageBox.Show("Product saved successfully.");



        }


        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            dataGridView1.ClearSelection();
            txt_barcodenumber.Enabled = true;
            check_barcode.Checked = true;
            lblProductId.Text = "0";
            check_barcode.Checked = true;
            txt_barcodenumber.Clear();
            txt_productName.Clear();
            txt_quantity.Clear();
            txt_price.Clear();
            txt_price.Clear();
            txt_barcodenumber.Focus();
            //btn_save.Text = "Save";



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


                var selectedProduct = productViewModelBindingSource.Current as ProductViewModel;

                if (selectedProduct != null)
                {
                    // Delete the product from the database
                    var productToDelete = _dbContext.Products.Find(selectedProduct.Id);
                    _dbContext.Products.Remove(productToDelete);
                    _dbContext.SaveChanges();

                    // Remove the product from the BindingSource
                    productViewModelBindingSource.Remove(selectedProduct);
                    ClearFields();
                    MessageBox.Show("Product deleted successfully.");
                }

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


            lblProductId.Text = selectedProductId.ToString();
            check_barcode.Checked = _product.IsBarcode;
            txt_barcodenumber.Text = _product.BarcodeNumber ?? string.Empty;
            txt_productName.Text = _product.ProductName;
            txt_quantity.Text = _product.Quantity.ToString();
            txt_price.Text = _product.Price.ToString();


        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//Only handled numbers
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
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


            var selectedProduct = productViewModelBindingSource.Current as ProductViewModel;
            int selectedProductIdText = Convert.ToInt32(lblProductId.Text);
            if (selectedProduct != null)
            {
                // Update the product in the database
                var productToUpdate = _dbContext.Products.Find(selectedProductIdText);

                productToUpdate.BarcodeNumber = txt_barcodenumber.Text;
                productToUpdate.ProductName = txt_productName.Text;
                productToUpdate.Quantity = Convert.ToInt32(txt_quantity.Text);
                productToUpdate.Price = Convert.ToDouble(txt_price.Text);

                _dbContext.SaveChanges();

                // Update the BindingSource
                selectedProduct.BarcodeNumber = productToUpdate.BarcodeNumber;
                selectedProduct.ProductName = productToUpdate.ProductName;
                selectedProduct.Quantity = productToUpdate.Quantity;
                selectedProduct.Price = productToUpdate.Price;

                productViewModelBindingSource.ResetCurrentItem(); // Refresh the grid
                ClearFields();
                MessageBox.Show("Record updated Successfully");
            }


        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var textFilter = txt_search.Text.ToLower();

            // Filter products from the database
            var filteredProducts = _dbContext.Products
                                             .Where(s => s.ProductName.ToLower().Contains(textFilter) || s.BarcodeNumber.ToLower().Contains(textFilter))
                                             .Include(p => p.AppUser) // Include related data if needed
                                             .AsNoTracking()
                                             .ToList();

            // Map Product objects to ProductViewModel objects
            var filteredProductViewModels = filteredProducts.Select(p => new ProductViewModel
            {
                Id = p.Id,
                IsBarcode = p.IsBarcode,
                BarcodeNumber = p.BarcodeNumber,
                ProductName = p.ProductName,
                Quantity = p.Quantity,
                Price = p.Price,
                AddedBy = p.AppUser.Name, // Get the name of the associated AppUser
                DateAdded = p.DateAdded
            }).ToList();

            // Clear the current binding source and add the filtered data
            productViewModelBindingSource.Clear();
            foreach (var productViewModel in filteredProductViewModels)
            {
                productViewModelBindingSource.Add(productViewModel);
            }
        }

        private void check_barcode_CheckedChanged(object sender, EventArgs e)
        {
            if (check_barcode.Checked)
            {
                txt_barcodenumber.Clear();
                txt_barcodenumber.Enabled = true;
                txt_barcodenumber.Focus();
            }
            else
            {
                txt_barcodenumber.Clear();
                txt_barcodenumber.Enabled = false;
                txt_productName.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

