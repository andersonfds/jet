using Commerce.Application.Core.DTO;

namespace Commerce.Application.Core
{
    public interface IUserApp
    {
        void Create(UserCreateRequestDTO user);
    }
}
