using Commerce.BLL.Base;
using Commerce.BLL.Core;
using Commerce.CrossCutting.Core.Interface;
using Commerce.Domain.Entity;

namespace Commerce.BLL
{
    public class UserBLL : BaseBLL, IUserBLL
    {

        public UserBLL(IServiceNotification notification) : base(notification)
        {
        }

        public void Create(User user)
        {
        }

        public User GetOneByEmail(string email)
        {
            return new User
            {
                Name = "John Doe",
                Email = "john@doe.com",
                Phone = "+5516991494455",
            };
        }

        public bool IsPasswordValid(User user, string password)
        {
            return true;
        }
    }
}
