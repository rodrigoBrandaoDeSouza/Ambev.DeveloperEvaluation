namespace Ambev.DeveloperEvaluation.Messaging.Events
{
    /// <summary>
    /// Event that represents the update of an existing sale.
    /// </summary>
    public class SaleUpdatedEvent : ISaleEvent
    {
        public Guid SaleId { get; set; }
        public DateTime OccurredAt { get; set; } = DateTime.UtcNow;
        public string Customer { get; set; } = string.Empty;
        public string Branch { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
    }
}
