using AutoMapper;
using Commerce.Application.Core.DTO;
using Commerce.Domain.Entity;

namespace Commerce.Application.Mapper
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductRequestDTO>().ReverseMap();
            CreateMap<ProductResponseDTO, Product>().ReverseMap();
        }
    }
}
