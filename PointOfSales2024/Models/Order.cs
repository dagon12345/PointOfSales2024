namespace PointOfSales2024.Models;

public class Order
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int OrderQuantity { get; set; }
    public double OverallPrice { get; set; }
    public double Cash { get; set; }
    public int AppUserId { get; set; }
    public DateTime DateTimeTransacted { get; set; }

    public Product Product { get; set; } = null!; // Child of our model Product
    public AppUser AppUser { get; set; } = null!; // Required reference navigation to princial AppUser.
   // public ICollection<Product> Products { get; } = new List<Product>();

}

