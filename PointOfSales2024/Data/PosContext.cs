using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PointOfSales2024.Models;

namespace PointOfSales2024.Data;

public class PosContext : DbContext
{

    public PosContext()
    {
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //  => optionsBuilder.UseSqlite("Data Source=pos.db")
    //    .LogTo(Console.WriteLine, LogLevel.Information);


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Use Application Data directory for storing the database. THis is located and created into C:\Users\<Username>\AppData\Roaming

        string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "POSDatabase", "pos.db");

        // Ensure the directory exists
        Directory.CreateDirectory(Path.GetDirectoryName(databasePath));

        try
        {
            // Check if the database file exists
            if (!File.Exists(databasePath))
            {
                // Copy the database from the application's installation directory if necessary
                string sourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pos.db");

                if (File.Exists(sourcePath))
                {
                    File.Copy(sourcePath, databasePath);
                }
                else
                {
                    // Initialize or create a new database if the source file does not exist
                    // For example, create a new empty database or log an error
                }
            }
        }
        catch (UnauthorizedAccessException ex)
        {
            // Handle access denied exceptions
            Console.WriteLine($"Access denied: {ex.Message}");
            // Inform the user or log the error
        }

        // Configure the DbContext to use the SQLite database
        optionsBuilder.UseSqlite($"Data Source={databasePath}")
            .LogTo(Console.WriteLine, LogLevel.Information);
    }



    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<AddedStock> AddedStocks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Product>()
        //.HasIndex(p => new { p.ProductName})
        //.IsUnique();
        modelBuilder.Entity<AddedStock>()
            .HasOne(a => a.AppUser)
            .WithMany(ad => ad.AddedStocks)
            .HasForeignKey(ad => ad.AppUserId)
            .HasPrincipalKey(a => a.AppUserId);

        modelBuilder.Entity<AddedStock>()
            .HasOne(p => p.Product)
            .WithMany(a => a.AddedStocks)
            .HasForeignKey(a => a.ProductId)
            .HasPrincipalKey(a => a.Id);

        modelBuilder.Entity<Order>()
            .HasOne(p => p.Product)
            .WithMany(o => o.Orders)
            .HasForeignKey(o => o.ProductId)
            .HasPrincipalKey(p => p.Id);


        modelBuilder.Entity<AppUser>()
            .HasMany(o => o.Orders)
            .WithOne(a => a.AppUser)
            .HasForeignKey(o => o.AppUserId)
            .HasPrincipalKey(a => a.AppUserId);


        modelBuilder.Entity<Product>()
            .HasOne(a => a.AppUser)
            .WithMany(p => p.Products)
            .HasForeignKey(p => p.AppUserId)
            .HasPrincipalKey(a => a.AppUserId);

        modelBuilder.Entity<AppUser>().HasData(
            new AppUser { AppUserId = 1, Name = "Lance", UserName = "admin", Password = "admin", IsAdmin = true },
            new AppUser { AppUserId = 2, Name = "Espina", UserName = "user", Password = "user", IsAdmin = false });

        modelBuilder.Entity<Product>().HasData(

        new Product
        {
            Id = 1,
            IsBarcode = true,
            BarcodeNumber = "1234",
            ProductName = "Milo",
            Quantity = 2,
            Price = 5,
            //Profit = 0,
            AppUserId = 1,
            DateAdded = DateTime.Now
        },
          new Product
          {
              Id = 2,
              IsBarcode = true,
              BarcodeNumber = "123456",
              ProductName = "Nido",
              Quantity = 5,
              Price = 10,
              //Profit = 2,
              AppUserId = 1,
              DateAdded = DateTime.Now
          });


    }

}

