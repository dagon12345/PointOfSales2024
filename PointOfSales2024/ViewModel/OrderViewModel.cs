namespace PointOfSales2024.ViewModel
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? Barcode { get; set; }
        public required string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double OverallPrice { get; set; }       
    }
}
