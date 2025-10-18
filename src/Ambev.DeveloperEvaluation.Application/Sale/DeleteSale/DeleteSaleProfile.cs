using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sale.DeleteSale
{
    /// <summary>
    /// AutoMapper profile for delete sale mappings.
    /// </summary>
    /// <remarks>
    /// This profile can be extended to handle any object-to-object mapping
    /// related to sale deletion.
    /// </remarks>
    public class DeleteSaleProfile : Profile
    {
        public DeleteSaleProfile()
        {
            CreateMap<Domain.Entities.Sale, DeleteSaleResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Success, opt => opt.Ignore())
                .ForMember(dest => dest.Message, opt => opt.Ignore());
        }
    }
}
