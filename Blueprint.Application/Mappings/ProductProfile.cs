using Blueprint.Application.Features.Products.Commands.Create;
using Blueprint.Application.Features.Products.Queries.GetAllCached;
using Blueprint.Application.Features.Products.Queries.GetAllPaged;
using Blueprint.Application.Features.Products.Queries.GetById;
using Blueprint.Domain.Entities.Catalog;
using AutoMapper;

namespace Blueprint.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsResponse, Product>().ReverseMap();
        }
    }
}