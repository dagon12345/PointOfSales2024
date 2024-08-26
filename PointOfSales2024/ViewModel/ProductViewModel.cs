using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace PointOfSales2024.ViewModel;

public class ProductViewModel
{
    public int Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public double Price { get; set; }
    public string AddedBy { get; set; } = string.Empty;
    public DateTime DateAdded { get; set; }
}

