namespace WhareHouseAutomation.Models
{
    public class Inbound
    {
        public int InboundId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public DateTime InboundDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
