using Blueprint.Application.Features.Brands.Commands.Create;
using Blueprint.Application.Features.Brands.Queries.GetAllCached;
using Blueprint.Application.Features.Brands.Queries.GetById;
using Blueprint.Domain.Entities.Catalog;
using AutoMapper;

namespace Blueprint.Application.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsCachedResponse, Brand>().ReverseMap();
        }
    }
}