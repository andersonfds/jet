using AutoMapper;
using Commerce.Application.Base;
using Commerce.Application.Core;
using Commerce.CrossCutting.Core.Interface;
using Commerce.Domain.Interfaces;

namespace Commerce.Application
{
    public class UserApp : BaseApp, IUserApp
    {
        private ICurrentUser CurrentUser;

        public UserApp(ICurrentUser currentUser, IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
            CurrentUser = currentUser;
        }

        public void Checkout()
        {
            throw new System.NotImplementedException();
        }

        public void GetMyCart()
        {
            throw new System.NotImplementedException();
        }
    }
}
