using System.ComponentModel.DataAnnotations;

namespace PointOfSales2024.ViewModel
{
    public class AddedStocksViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string BarcodeNumber { get; set; }
        public required string ProductName { get; set; }
        public double Price { get; set; }
        public required string AddedBy { get; set; }
        [Display(Name ="Quantity Added")]
        public int  QuantityAdded { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
