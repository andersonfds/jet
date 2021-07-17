using System;

namespace Commerce.Domain.Interfaces
{
    public abstract class IEntity
    {
        public Guid Id { get; set; }
    }
}
