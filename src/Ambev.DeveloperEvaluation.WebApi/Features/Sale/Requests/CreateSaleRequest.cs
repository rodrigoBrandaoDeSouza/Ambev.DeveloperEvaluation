namespace Ambev.DeveloperEvaluation.WebApi.Features.Sale.Requests
{
    /// <summary>
    /// Represents the HTTP request payload to create a new sale.
    /// </summary>
    public class CreateSaleRequest
    {
        public string Customer { get; set; } = string.Empty;
        public string Branch { get; set; } = string.Empty;
        public List<SaleItemRequest> Items { get; set; } = new();
    }

    /// <summary>
    /// Represents a sale item in the creation request.
    /// </summary>
    public class SaleItemRequest
    {
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
