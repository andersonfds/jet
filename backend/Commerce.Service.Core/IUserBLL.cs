using Commerce.Domain.Entity;

namespace Commerce.BLL.Core
{
    public interface IUserBLL
    {
        User GetOneByEmail(string email);

        void Create(User user);

        bool IsPasswordValid(User user, string password);
    }
}
