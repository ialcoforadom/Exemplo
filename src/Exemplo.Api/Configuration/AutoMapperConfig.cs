using AutoMapper;
using Exemplo.Business.Models.Pagination;

namespace Exemplo.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            #region PaginacaoFiltros
            CreateMap<PaginationFilterBase, PaginationFilterBase>()
                .ForMember(dest => dest.PageNumber, src => src.MapFrom(src => src.PageNumber < 1 ? 1 : src.PageNumber))
                .ForMember(dest => dest.PageSize, src => src.MapFrom(src => src.PageSize > 50 ? 50 : src.PageSize));
            #endregion
        }
    }
}
