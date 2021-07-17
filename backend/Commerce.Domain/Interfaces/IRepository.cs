﻿using System.Collections.Generic;

namespace Commerce.Domain.Interfaces
{
    public interface IRepository<Entity> where Entity : IEntity
    {
        void Remove(Entity entity);

        void Remove(IEnumerable<Entity> entites);

        void Edit(Entity entity);

        void Edit(IEnumerable<Entity> entites);

        void Add(Entity entity);

        void Add(IEnumerable<Entity> entites);
    }
}
