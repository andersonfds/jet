using AutoMapper;
using Commerce.Application.Base;
using Commerce.Application.Core;
using Commerce.Application.Core.DTO;
using Commerce.BLL.Core;
using Commerce.CrossCutting.Core.Interface;
using Commerce.Domain.Entity;
using Commerce.Domain.Interfaces;

namespace Commerce.Application
{
    public class UserApp : BaseApp, IUserApp
    {
        protected readonly IUserBLL UserBLL;

        public UserApp(IUnitOfWork uow, IMapper mapper, IUserBLL userBLL) : base(uow, mapper)
        {
            UserBLL = userBLL;
        }

        public void Create(UserCreateRequestDTO userDto)
        {
            var user = Mapper.Map<User>(userDto);
            UserBLL.Create(user);
            UnitOfWork.Save();
        }
    }
}
