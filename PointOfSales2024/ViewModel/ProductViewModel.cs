using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace PointOfSales2024.ViewModel;

public class ProductViewModel
{
    public int Id { get; set; }
    public bool IsBarcode { get; set; }
    public string? BarcodeNumber { get; set; }
    public bool IsWholeSale { get; set; }
    public int wholeSaleQuantity { get; set; } = 0;
    public string ProductName { get; set; } = string.Empty;
    public int Quantity { get; set; } = 0;
    public double Price { get; set; } = 0;
    public double Profit { get; set; } = 0;
    public required string AddedBy { get; set; }
    public DateTime DateAdded { get; set; }
}

