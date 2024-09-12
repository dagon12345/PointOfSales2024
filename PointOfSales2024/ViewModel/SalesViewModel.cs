namespace PointOfSales2024.ViewModel
{
    public class SalesViewModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; } // From product model
        public string ProductName { get; set; }//From product model
        public string ProductBarcode { get; set; }//From Product model
        public double Price { get; set; }//FromProduct model
        public int OrderQuantity { get; set; }//From order
        public double OverallPrice { get; set; }//From order
        public required string TransactedBy { get; set; }//From order
        public DateTime DateTimeTransacted { get; set; }//From order
        public double Cash { get; set; }

 
    }
}
