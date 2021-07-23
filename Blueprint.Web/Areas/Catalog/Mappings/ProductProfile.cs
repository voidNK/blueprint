using Blueprint.Application.Features.Products.Commands.Create;
using Blueprint.Application.Features.Products.Commands.Update;
using Blueprint.Application.Features.Products.Queries.GetAllCached;
using Blueprint.Application.Features.Products.Queries.GetById;
using Blueprint.Web.Areas.Catalog.Models;
using AutoMapper;

namespace Blueprint.Web.Areas.Catalog.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<GetAllProductsCachedResponse, ProductViewModel>().ReverseMap();
            CreateMap<GetProductByIdResponse, ProductViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, ProductViewModel>().ReverseMap();
            CreateMap<UpdateProductCommand, ProductViewModel>().ReverseMap();
        }
    }
}