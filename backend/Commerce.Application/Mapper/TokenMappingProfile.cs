using AutoMapper;
using Commerce.Application.Core.DTO;
using Commerce.Domain.Entity;

namespace Commerce.Application.Mapper
{
    public class TokenMappingProfile : Profile
    {
        public TokenMappingProfile()
        {
            CreateMap<TokenResponseDTO, Token>().ReverseMap();
        }
    }
}
