using Microsoft.EntityFrameworkCore;
using PointOfSales2024.Models;

namespace PointOfSales2024.Data;

public class PosContext : DbContext
{

    public PosContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseSqlite("Data Source=pos.db");

    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Product>()
        //.HasIndex(p => new { p.ProductName})
        //.IsUnique();

        modelBuilder.Entity<AppUser>().HasData(
            new AppUser { AppUserId = 1, Name = "Lance", UserName = "lauespina", Password = "admin", IsAdmin = true },
            new AppUser { AppUserId = 2, Name = "Espina", UserName = "lauespina1", Password = "espina", IsAdmin = false });

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

