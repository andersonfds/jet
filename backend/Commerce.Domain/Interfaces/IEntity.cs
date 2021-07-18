using FluentValidation;
using System;

namespace Commerce.Domain.Interfaces
{
    public abstract class IEntity<E> : AbstractValidator<E> where E : IEntity<E>
    {
        public Guid Id { get; set; }

        public virtual bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
