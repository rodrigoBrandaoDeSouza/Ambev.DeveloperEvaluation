using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.GetSale
{
    public class GetSaleByIdHandler : IRequestHandler<GetSaleByIdCommand, GetSaleByIdResponse>
    {
        /// <summary>
        /// Handler for processing <see cref="UpdateSaleCommand"/> requests.
        /// </summary>
        /// <remarks>
        /// This handler validates the request, retrieves the sale from the repository,
        /// applies updates, calculates discounts, and persists the changes.
        /// </remarks>
        public Task<GetSaleByIdResponse> Handle(GetSaleByIdCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
