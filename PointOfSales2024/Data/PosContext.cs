using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PointOfSales2024.Models;

namespace PointOfSales2024.Data;

public class PosContext : DbContext
{

    public PosContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseSqlite("Data Source=pos.db")
        .LogTo(Console.WriteLine, LogLevel.Information);

    

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

