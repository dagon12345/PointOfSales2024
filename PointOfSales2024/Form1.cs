using Microsoft.EntityFrameworkCore;
using PointOfSales2024.Data;
using PointOfSales2024.ViewModel;

namespace PointOfSales2024
{
    public partial class Form1 : Form
    {
        private PosContext? _dbContext;
        public Form1()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            using (var context = new PosContext())
            {
                // Ensure the database is created
                //context.Database.EnsureCreated();

                // Load the products from the database, including the related AppUser data
                var products = context.Products
                    .Include(p => p.AppUser)  // Include related data
                    .ToList();

                // Map Product objects to ProductViewModel objects
                var productViewModels = products.Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    Quantity = p.Quantity,
                    Price = p.Price,
                    AddedBy = p.AppUser.Name,  // Get the name of the associated AppUser
                    DateAdded = p.DateAdded

                }).ToList();

                // Bind the product list to the DataGridView
                dataGridView1.DataSource = productViewModels;
                dataGridView1.Columns["AddedBy"].HeaderText = "Added By";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (var context = new PosContext())
            {
                context.SaveChanges();
                dataGridView1.Refresh();
            }
        }
    }
}
