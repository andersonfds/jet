using Commerce.Data.Core.DbContexts;
using Commerce.Domain.Interfaces;
using System.Collections.Generic;

namespace Commerce.Data.Repository
{
    public abstract class BaseRepository<Entity> where Entity : IEntity
    {
        protected readonly IAppDbContext Context;

        public BaseRepository(IAppDbContext context)
        {
            Context = context;
        }

        public void Remove(Entity entity)
        {
            Context.GetEntity<Entity>().Remove(entity);
        }

        public void Remove(IEnumerable<Entity> entites)
        {
            Context.GetEntity<Entity>().RemoveRange(entites);
        }

        public void Edit(Entity entity)
        {
            Context.GetEntity<Entity>().Update(entity);
        }

        public void Edit(IEnumerable<Entity> entites)
        {
            Context.GetEntity<Entity>().UpdateRange(entites);
        }

        public void Add(Entity entity)
        {
            Context.GetEntity<Entity>().Add(entity);
        }

        public void Add(IEnumerable<Entity> entites)
        {
            Context.GetEntity<Entity>().AddRange(entites);
        }
    }
}
