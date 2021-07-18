using Commerce.Data.Core.DbContexts;
using Commerce.Data.Repository;
using Commerce.Domain.Entity;
using Commerce.Repository.Core;
using System.Linq;

namespace Commerce.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IAppDbContext context) : base(context)
        {
        }

        public User GetOneByEmail(string email)
        {
            var query = from u in Context.GetEntity<User>()
                        where u.Email.ToUpper() == email.ToUpper()
                        select u;

            return query.FirstOrDefault();
        }
    }
}
