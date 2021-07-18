using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Commerce.Data.Core.DbContexts
{
    public interface IAppDbContext
    {
        ChangeTracker ChangeTracker { get; }

        DatabaseFacade Database { get; }

        DbSet<Entity> GetEntity<Entity>() where Entity : class;

        int SaveChanges();
    }
}
