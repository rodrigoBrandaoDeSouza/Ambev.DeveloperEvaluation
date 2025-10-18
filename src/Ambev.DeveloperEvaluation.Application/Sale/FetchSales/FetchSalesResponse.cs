namespace Ambev.DeveloperEvaluation.Application.Sale.FetchSales
{
    /// <summary>
    /// Response returned after retrieving all sales.
    /// </summary>
    /// <remarks>
    /// Contains a collection of sales, each including key details and items.
    /// </remarks>
    public class FetchSalesResponse
    {
        /// <summary>
        /// Gets or sets the list of sales retrieved.
        /// </summary>
        public List<FetchSaleItemResponse> Sales { get; set; } = new();
    }

    /// <summary>
    /// Represents a single sale in the fetched list.
    /// </summary>
    public class FetchSaleItemResponse
    {
        public Guid Id { get; set; }
        public string SaleNumber { get; set; } = string.Empty;
        public string Customer { get; set; } = string.Empty;
        public string Branch { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public bool Cancelled { get; set; }
        public List<FetchSaleProductResponse> Items { get; set; } = new();
    }

    /// <summary>
    /// Represents a product item within a sale.
    /// </summary>
    public class FetchSaleProductResponse
    {
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
