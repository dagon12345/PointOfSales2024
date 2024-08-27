using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSales2024.Models;

public class Product
{
    public int Id { get; set; }
    public bool IsBarcode { get; set; }
    public string? BarcodeNumber { get; set; }
    public bool IsWholeSale { get; set; }
    public int wholeSaleQuantity { get; set; } = 0;
    [Required]
    public required string ProductName { get; set; }
    public int Quantity { get; set; } = 0;
    public double Price { get; set; } = 0;
    public double Profit { get; set; } = 0;

    //[Column("Added by")]
    public int AppUserId { get; set; }
    public DateTime DateAdded { get; set; } = DateTime.Now;

    public AppUser AppUser { get; set; } = null!; // Required reference navigation to princial AppUser.
}

