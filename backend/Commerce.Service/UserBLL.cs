using Commerce.BLL.Base;
using Commerce.BLL.Core;
using Commerce.CrossCutting.Core.Interface;
using Commerce.Domain.Entity;
using Commerce.Repository.Core;

namespace Commerce.BLL
{
    public class UserBLL : BaseBLL, IUserBLL
    {
        protected readonly IUserRepository UserRepository;

        public UserBLL(IServiceNotification notification, IUserRepository userRepository) : base(notification)
        {
            UserRepository = userRepository;
        }

        public void Create(User user)
        {
            if (!user.IsValid())
            {
                Notify("invalid_domain", "Não foi possível salvar o usuário");
                return;
            }

            var dbUser = GetOneByEmail(user.Email);

            if (dbUser != null)
            {
                Notify("invalid_email", "O e-mail fornecido já está em uso");
                return;
            }

            UserRepository.Add(user);
        }

        public User GetOneByEmail(string email)
        {
            return UserRepository.GetOneByEmail(email);
        }

        public bool IsPasswordValid(User user, string password)
        {
            return user?.Password == password && user != null;
        }
    }
}
