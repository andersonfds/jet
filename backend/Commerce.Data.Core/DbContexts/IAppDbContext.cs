using Commerce.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections;
using System.Collections.Generic;

namespace Commerce.Data.Core.DbContexts
{
    public interface IAppDbContext
    {
        ChangeTracker ChangeTracker { get; }

        DatabaseFacade Database { get; }

        DbSet<Entity> GetEntity<Entity>() where Entity : IEntity;

        int SaveChanges();
    }
}
