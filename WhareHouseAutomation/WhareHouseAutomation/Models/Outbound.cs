namespace WhareHouseAutomation.Models
{
    public class Outbound
    {
        public int OutBoundId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public DateTime OutboundDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
