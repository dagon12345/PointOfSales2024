using Microsoft.EntityFrameworkCore;
using PointOfSales2024.Data;
using PointOfSales2024.Forms;
using PointOfSales2024.ViewModel;
using Syncfusion.WinForms.Input.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSales2024.Popups
{
    public partial class SearchProductPopUp : Form
    {
        private PosContext _dbContext;
        public SearchProductPopUp()
        {
            InitializeComponent();
   
            txt_search.Focus();

            // Handle the KeyDown event
            this.KeyPreview = true;
            this.KeyDown += SearchProductPopUp_KeyDown;

            //Handle row double-click event or enter key for selection
            //dgSearch.CellDoubleClick += DgSearch_CellDoubleCLick;
            dgSearch.KeyDown += DgSearch_KeyDown;

        }
        protected override async void OnLoad(EventArgs e)
        {

            base.OnLoad(e);
            _dbContext = new PosContext();

            using (var context = new PosContext())
            {
                var products = await context.Products
                     .Include(a => a.AppUser)
                     .ToListAsync();

                var productViewModel = products.Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    Price = p.Price,
                    AddedBy = p.AppUser.Name,
                    DateAdded = p.DateAdded,
                }).ToList();

                productViewModelBindingSource.DataSource = productViewModel;
                dgSearch.DataSource = productViewModelBindingSource;


            }

            //Handle row double-click event or enter key for selection
            dgSearch.CellDoubleClick += DgSearch_CellDoubleClick;
            dgSearch.KeyDown += DgSearch_KeyDown;
        }
        private void DgSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectProduct();
        }
        private void DgSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SelectProduct();
            }
        }
        private void SelectProduct()
        {
            if(dgSearch.CurrentRow != null)
            {
                //Get the selected product name
                var selectedProduct = dgSearch.CurrentRow.DataBoundItem as ProductViewModel;
                if(selectedProduct != null)
                {
                    //access the transactionform and set the product name
                    var transactionForm = Application.OpenForms.OfType<TransactionForm>().FirstOrDefault();
                    if(transactionForm != null)
                    {
                        transactionForm.txtProductName.Text = selectedProduct.ProductName;
                    }

                    //close the searchProductPopup form
                    this.Close();

                }
            }
        }
        private void SearchProductPopUp_Load(object sender, EventArgs e)
        {

        }

        private void SearchProductPopUp_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Ctrl+W or Alt+F4 is pressed
            if ((e.Control && e.KeyCode == Keys.W) || (e.Alt && e.KeyCode == Keys.F4))
            {
                // Close the form
                this.Close();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var textFilter = txt_search.Text.ToLower();

            var filteredProducts = _dbContext.Products
                .Where(p => p.ProductName.ToLower().Contains(textFilter))
                .Include(a => a.AppUser)
                .AsNoTracking()
                .ToList();

            var filteredProductViewModels = filteredProducts.Select(p => new ProductViewModel 
            {
                Id = p.Id,
                ProductName = p.ProductName,
                Price = p.Price,
                AddedBy = p.AppUser.Name,
                DateAdded = p.DateAdded,


            }).ToList();

            productViewModelBindingSource.Clear();
            foreach(var productViewModel in filteredProductViewModels)
            {
                productViewModelBindingSource.Add(productViewModel);
            }


        }
    }
}
