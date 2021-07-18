using Commerce.Domain.Entity;
using Commerce.Domain.Interfaces;

namespace Commerce.Repository.Core
{
    public interface IUserRepository : IRepository<User>
    {
        User GetOneByEmail(string email);
    }
}
