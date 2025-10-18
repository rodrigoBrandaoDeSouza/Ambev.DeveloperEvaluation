using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.FetchSales
{
    /// <summary>
    /// Handler for processing <see cref="FetchSalesCommand"/> requests.
    /// </summary>
    /// <remarks>
    /// This handler retrieves all sales from the repository,
    /// maps them into response objects, and returns the collection.
    /// </remarks>
    public class FetchSalesHandler : IRequestHandler<FetchSalesCommand, FetchSalesResponse>
    {
        public Task<FetchSalesResponse> Handle(FetchSalesCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
