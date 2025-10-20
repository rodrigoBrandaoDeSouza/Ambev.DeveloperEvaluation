using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sale.UpdateSale
{
    /// <summary>
    /// AutoMapper profile for mapping between UpdateSaleCommand and Sale entity.
    /// </summary>
    /// <remarks>
    /// Maps the command to the domain entity and the updated entity back to the result.
    /// </remarks>
    public class UpdateSaleProfile : Profile
    {
        public UpdateSaleProfile()
        {
            CreateMap<UpdateSaleCommand, Domain.Entities.Sale>();

            CreateMap<UpdateSaleItemDto, SaleItem>();
        }
    }
}
