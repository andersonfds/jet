using AutoMapper;
using Commerce.Application.Base;
using Commerce.Application.Core;
using Commerce.Application.Core.DTO;
using Commerce.BLL.Core;
using Commerce.Domain.Interfaces;

namespace Commerce.Application
{
    public class LoginApp : BaseApp, ILoginApp
    {
        protected readonly ILoginBLL LoginBLL;

        public LoginApp(ILoginBLL loginBLL, IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
            LoginBLL = loginBLL;
        }

        public TokenResponseDTO Login(LoginRequestDTO request)
        {
            var result = LoginBLL.IssueLoginToken(request.Email, request.Password);
            return Done<TokenResponseDTO>(result);
        }
    }
}
