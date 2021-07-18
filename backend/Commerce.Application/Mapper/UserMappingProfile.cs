using AutoMapper;
using Commerce.Application.Core.DTO;
using Commerce.Domain.Entity;

namespace Commerce.Application.Mapper
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserCreateRequestDTO>().ReverseMap();
        }
    }
}
