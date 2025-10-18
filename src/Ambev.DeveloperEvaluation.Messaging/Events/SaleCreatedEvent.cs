namespace Ambev.DeveloperEvaluation.Messaging.Events
{
    /// <summary>
    /// Event that represents the creation of a new sale.
    /// </summary>
    public class SaleCreatedEvent : ISaleEvent
    {
        public Guid SaleId { get; set; }
        public DateTime OccurredAt { get; set; } = DateTime.UtcNow;

        public string Customer { get; set; } = string.Empty;
        public string Branch { get; set; } = string.Empty;
        public List<SaleCreatedItem> Items { get; set; } = new();
    }

    public class SaleCreatedItem
    {
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
