using Ambev.DeveloperEvaluation.Application.Models;
using Ambev.DeveloperEvaluation.Domain.Services;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.UpdateSale
{
    public class UpdateSaleHandler : IRequestHandler<UpdateSaleCommand, OperationResult<Domain.Entities.Sale>>
    {
        private readonly ISaleService _saleService;
        private readonly IMapper _mapper;

        public UpdateSaleHandler(ISaleService saleService, IMapper mapper)
        {
            _saleService = saleService;
            _mapper = mapper;
        }

        /// <summary>
        /// Handler for processing <see cref="UpdateSaleCommand"/> requests.
        /// </summary>
        /// <remarks>
        /// This handler validates the request, retrieves the sale from the repository,
        /// applies updates, calculates discounts, and persists the changes.
        /// </remarks>
        public async Task<OperationResult<Domain.Entities.Sale>> Handle(UpdateSaleCommand request, CancellationToken cancellationToken)
        {
            var existingSale = await _saleService.GetByIdAsync(request.Id);

            if(existingSale is null)
                return OperationResult<Domain.Entities.Sale>.Fail($"Sale with ID {request.Id} not found");

            var sale = _mapper.Map<Domain.Entities.Sale>(request);
            
            var saleUpdated = await _saleService.UpdateAsync(sale);

            return OperationResult<Domain.Entities.Sale>.Ok(saleUpdated, "Sale updated successfully");
        }
    }
}
