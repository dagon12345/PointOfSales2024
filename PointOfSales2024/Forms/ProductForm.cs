using Microsoft.EntityFrameworkCore;
using PointOfSales2024.Data;
using PointOfSales2024.Models;
using PointOfSales2024.ViewModel;
using System.Data;

namespace PointOfSales2024
{
    public partial class ProductForm : Form
    {
        private PosContext _dbContext;
        private Product? _product;
        private ProductViewModel _productViewModel;
        private AddedStock _stock;
        public string _Name;
        public bool _IsAdmin;
        public int _appUserId;
        public ProductForm(string name, bool isAdmin, int appUserId)
        {
            InitializeComponent();
            txt_barcodenumber.Focus();

            _Name = name;
            _IsAdmin = isAdmin;
            _appUserId = appUserId;


            if (_IsAdmin != true)
            {
                btn_remove.Visible = false;
            }

        }


        // Event handler to change row color based on quantity
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Quantity")
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int quantity))
                {
                    if (quantity <= 10 && quantity >= 1)
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(250, 223, 161); // Color #FADFA1
                        return;
                    }
                    if (quantity == 0)
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(201, 104, 104); // Color #C96868

                    }
                    else
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    }


                }
            }

        }
        private void CellsFormula()
        {
            double price = 0.0;
            double quantity = 0.0;
            double overallTotal = 0.0;
            double totalAmount = 0.0;
            //double amount = Convert.ToDouble(lblAmount.Text);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                price = Convert.ToDouble(row.Cells["Price"].Value);
                quantity = Convert.ToDouble(row.Cells["Quantity"].Value);
                overallTotal = Convert.ToDouble(row.Cells["OverallTotal"].Value);


                overallTotal = quantity * price;
                
                //Update the Overall total cell with the calculated value.
                row.Cells["OverallTotal"].Value = overallTotal;

                totalAmount += overallTotal;

                lblAmount.Text = $"Total amount entered: {totalAmount.ToString("C2", new System.Globalization.CultureInfo("en-PH"))}";
;                
            }
            //Count the total number of producs from datagridView1.
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                lblCount.Text = $"Total Product entered: {i + 1}";
            }

            if(dataGridView1.Rows.Count == 0)
            {
                lblCount.Text = $"Total Product entered: 0";
                lblAmount.Text = $"Total amount entered: 0";

            }

        }

        //private BindingList<ProductViewModel> list = new BindingList<ProductViewModel>();
        private async Task LoadProductAsync()
        {



            using (var context = new PosContext())
            {

                // Delete and Create database below.
                //await context.Database.EnsureDeletedAsync();
                //await context.Database.EnsureCreatedAsync();

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
                CellsFormula();
                dataGridView1.ClearSelection();

                //Subscribe to the CellFormating event
                dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            }

        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _dbContext = new PosContext();
            await LoadProductAsync();
        }

        private void Save()
        {
            //try
            //{
            /*Instead of getting data from database, we used the refresh grid same reflected as what we've added 
        into our database.*/
            if (txt_productName.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Fill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                AppUserId = _appUserId, // or get this dynamically/ we will use this later when we create login
                DateAdded = DateTime.Now
            };

            _dbContext.Products.Add(_product); // Add the new product to the context
            _dbContext.SaveChanges(); // Save changes to the database


            //Add into AddedStock database.

            int productId = Convert.ToInt32(lblProductId.Text);
            int quantity = Convert.ToInt32(txt_quantity.Text);

            _stock = new AddedStock
            {
                ProductId = _product.Id,
                Quantity = quantity,
                DateAdded = DateTime.Now,
                AppUserId = _appUserId, // we can change this later once the login form is created.
            };

            _dbContext.AddedStocks.Add(_stock); // Add the new product to the context


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
                AddedBy = _Name,  // replace with actual user name/ we will use this later when we create login
                DateAdded = _product.DateAdded
            };

            productViewModelBindingSource.Add(newProductViewModel);

            ClearFields();
            MessageBox.Show("Product saved successfully.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show($"Error message : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Update()
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Empty table.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txt_productName.Text == "")
                {
                    MessageBox.Show("Select what you want to update", "Select", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var selectedProduct = productViewModelBindingSource.Current as ProductViewModel;
                int selectedProductIdText = Convert.ToInt32(lblProductId.Text);
                if (selectedProduct != null)
                {
                    // Update the product in the database
                    var productToUpdate = _dbContext.Products.Find(selectedProductIdText);

                    productToUpdate.IsBarcode = check_barcode.Checked;
                    productToUpdate.BarcodeNumber = txt_barcodenumber.Text;
                    productToUpdate.ProductName = txt_productName.Text;
                    if (btn_save.Text == "Add Stocks")
                    {
                        productToUpdate.Quantity += Convert.ToInt32(txt_quantity.Text);

                    }

                    productToUpdate.Price = Convert.ToDouble(txt_price.Text);

                    _dbContext.SaveChanges();


                    //Add into AddedStock database only if the button text is Add Stocks.
                    if (btn_save.Text == "Add Stocks")
                    {


                        int productId = Convert.ToInt32(lblProductId.Text);
                        int quantity = Convert.ToInt32(txt_quantity.Text);

                        _stock = new AddedStock
                        {
                            ProductId = productId,
                            Quantity = quantity,
                            DateAdded = DateTime.Now,
                            AppUserId = _appUserId, // we can change this later once the login form is created.
                        };

                        _dbContext.AddedStocks.Add(_stock); // Add the new product to the context
                        _dbContext.SaveChanges(); // Save changes to the database
                    }

                    // Update the BindingSource
                    selectedProduct.IsBarcode = productToUpdate.IsBarcode;
                    selectedProduct.BarcodeNumber = productToUpdate.BarcodeNumber;
                    selectedProduct.ProductName = productToUpdate.ProductName;
                    selectedProduct.Quantity = productToUpdate.Quantity;
                    selectedProduct.Price = productToUpdate.Price;

                    productViewModelBindingSource.ResetCurrentItem(); // Refresh the grid

                    if (lblStatus.Text != "Status: Adding Stocks")
                    {
                        ClearFields();
                        //return;


                    }
                    else
                    {
                        clearStocksAdding();// for adding of stocks

                    }

                    MessageBox.Show("Record updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error message : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clearStocksAdding()
        {
            txt_quantity.Text = "0";

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (btn_save.Text == "Add Stocks")
            {
                if (txt_productName.Text == "")
                {
                    MessageBox.Show("Please select a product you want to add a stocks.", "Select", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txt_quantity.Text == "" || txt_quantity.Text == "0")
                {
                    MessageBox.Show("You can't add an empty stock. Please enter a valid stocks to proceed", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Update();//Addstocks condition inside.
                //MessageBox.Show("Add Stocks here.");
                return;
            }

            if (btn_save.Text != "Save")
            {
                Update(); // Update if the button name is not save.
                return;
            }
            // Save if no validation is meet above.
            Save();
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
            btn_save.Text = "Save";
            txt_quantity.Enabled = true;
            CellsFormula();
            txt_barcodenumber.Focus();




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


            if (MessageBox.Show("Are you sure you want to delete this product? Deleting the product may result to deleted related sales and added stocks. Continue?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    MessageBox.Show("Product deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


            //Condition for our particular fields.

            if (lblStatus.Text != "Status: Adding Stocks")
            {


                btn_save.Text = "Update";
                txt_quantity.Enabled = false; //Disabled because we can't update a quantity we instead add a stocks.


            }
            else
            {
                txt_quantity.Text = "0";
                txt_quantity.Focus();
            }

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

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            //base.OnLoad(e);
            await LoadProductAsync();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all the fields?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearFields();
            }

        }
    }
}

