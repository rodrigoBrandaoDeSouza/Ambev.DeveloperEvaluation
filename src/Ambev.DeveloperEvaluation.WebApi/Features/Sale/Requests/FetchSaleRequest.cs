namespace Ambev.DeveloperEvaluation.WebApi.Features.Sale.Requests
{
    /// <summary>
    /// Represents optional filtering parameters for fetching sales.
    /// </summary>
    public class FetchSalesRequest
    {
        public string? Customer { get; set; }
        public string? Branch { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
