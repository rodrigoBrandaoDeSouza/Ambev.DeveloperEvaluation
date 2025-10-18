namespace Ambev.DeveloperEvaluation.Application.Sale.UpdateSale
{
    /// <summary>
    /// Result returned after updating a sale.
    /// </summary>
    /// <remarks>
    /// Contains information about the updated sale, including total amount and updated items.
    /// </remarks>
    public class UpdateSaleResult
    {
        public Guid Id { get; set; }
        public string SaleNumber { get; set; } = string.Empty;
        public string Customer { get; set; } = string.Empty;
        public string Branch { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public bool Cancelled { get; set; }
        public List<UpdateSaleItemResult> Items { get; set; } = new();
    }

    public class UpdateSaleItemResult
    {
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
