using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sale.CreateSale
{
    /// <summary>
    /// AutoMapper profile for mapping between CreateSaleCommand and Sale entity.
    /// </summary>
    public class CreateSaleProfile : Profile
    {
        public CreateSaleProfile()
        {
            CreateMap<CreateSaleCommand, Domain.Entities.Sale>();

            CreateMap<CreateSaleItemDto, SaleItem>();
        }
    }
}
