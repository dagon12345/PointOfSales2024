using Microsoft.EntityFrameworkCore;
using PointOfSales2024.Data;

namespace PointOfSales2024
{
    public partial class Form1 : Form
    {
        private PosContext? _dbContext;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this._dbContext = new PosContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this._dbContext.Database.EnsureCreated();

            this._dbContext.Products.Load();


            this.productBindingSource.DataSource = _dbContext.Products.Local.ToBindingList();
            // this._dbContext = new PosContext();

            //// Uncomment the line below to start fresh with a new database.
            //// this.dbContext.Database.EnsureDeleted();

            //this._dbContext.Products.Load();

            //using (var context = new PosContext())
            //{

            //    context.Database.EnsureCreated();
            //    context.Database.EnsureDeleted();

            //    context.Products.Load();
            //    // Load the products from the database
            //    //var products = context.Products
            //    //    .Include(x => x.AppUser)
            //    //   // .ThenInclude(x => x.Name)
            //    //    //.ThenInclude(x => x.)
            //    //    .ToList();

            //    // Bind the product data to the BindingSource
            //    productBindingSource.DataSource = context;
            //}

            //this.productBindingSource.DataSource = _dbContext.Products.Local.ToBindingList();
        }

    }
}
