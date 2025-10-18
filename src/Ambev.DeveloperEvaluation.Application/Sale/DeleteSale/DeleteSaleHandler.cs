using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.DeleteSale
{
    public class DeleteSaleHandler : IRequestHandler<DeleteSaleCommand, DeleteSaleResponse>
    {
        /// <summary>
        /// Handler for processing <see cref="DeleteSaleCommand"/> requests.
        /// </summary>
        /// <remarks>
        /// This handler is responsible for validating the delete request, 
        /// performing the deletion using <see cref="ISaleRepository"/>,
        /// and returning the result as <see cref="DeleteSaleResponse"/>.
        /// </remarks>
        public Task<DeleteSaleResponse> Handle(DeleteSaleCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
