using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sale.FetchSales
{
    /// <summary>
    /// AutoMapper profile for mapping Sale entities to FetchSales response objects.
    /// </summary>
    /// <remarks>
    /// Maps between the domain model and the FetchSalesResponse DTOs.
    /// </remarks>
    public class FetchSalesProfile : Profile
    {
        public FetchSalesProfile()
        {
            CreateMap<Domain.Entities.Sale, FetchSaleItemResponse>();
            CreateMap<SaleItem, FetchSaleProductResponse>();
        }
    }
}
