namespace WhareHouseAutomation.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal StockBalance { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public string Currency { get; set; }
    }
}
