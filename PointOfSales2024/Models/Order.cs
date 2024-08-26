namespace PointOfSales2024.Models;

public class Order
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int OrderQuantity { get; set; }
    public int TransactedBy { get; set; }
    public DateTime DateTimeTransacted { get; set; }

    //public AppUser AppUser { get; set; } = null!; // Required reference navigation to princial AppUser.
}

