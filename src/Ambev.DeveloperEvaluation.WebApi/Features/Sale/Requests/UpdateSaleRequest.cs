namespace Ambev.DeveloperEvaluation.WebApi.Features.Sale.Requests
{
    /// <summary>
    /// Represents the HTTP request payload to update an existing sale.
    /// </summary>
    public class UpdateSaleRequest
    {
        public string Customer { get; set; } = string.Empty;
        public string SaleNumber { get; set; } = string.Empty;
        public string Branch { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public bool Cancelled { get; set; }
        public List<SaleItemRequest> Items { get; set; } = new();
    }
}
