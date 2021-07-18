using Commerce.Application.Core.DTO;

namespace Commerce.Application.Core
{
    public interface ILoginApp
    {
        TokenResponseDTO Login(LoginRequestDTO request);
    }
}
