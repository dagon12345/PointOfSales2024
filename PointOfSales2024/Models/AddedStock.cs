namespace PointOfSales2024.Models
{
    public class AddedStock
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; }
        public int AppUserId { get; set; }

        public Product Product { get; set; } = null!;
        public AppUser AppUser { get; set; } = null!;


    }
}
