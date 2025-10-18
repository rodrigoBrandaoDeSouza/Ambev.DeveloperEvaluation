using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.UpdateSale
{
    public class UpdateSaleHandler : IRequestHandler<UpdateSaleCommand, UpdateSaleResult>
    {
        /// <summary>
        /// Handler for processing <see cref="UpdateSaleCommand"/> requests.
        /// </summary>
        /// <remarks>
        /// This handler validates the request, retrieves the sale from the repository,
        /// applies updates, calculates discounts, and persists the changes.
        /// </remarks>
        public Task<UpdateSaleResult> Handle(UpdateSaleCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
