using Blueprint.Application.Features.Brands.Commands.Create;
using Blueprint.Application.Features.Brands.Commands.Update;
using Blueprint.Application.Features.Brands.Queries.GetAllCached;
using Blueprint.Application.Features.Brands.Queries.GetById;
using Blueprint.Web.Areas.Catalog.Models;
using AutoMapper;

namespace Blueprint.Web.Areas.Catalog.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<GetAllBrandsCachedResponse, BrandViewModel>().ReverseMap();
            CreateMap<GetBrandByIdResponse, BrandViewModel>().ReverseMap();
            CreateMap<CreateBrandCommand, BrandViewModel>().ReverseMap();
            CreateMap<UpdateBrandCommand, BrandViewModel>().ReverseMap();
        }
    }
}