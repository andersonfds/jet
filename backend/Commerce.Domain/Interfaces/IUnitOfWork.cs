using System;

namespace Commerce.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        void Save();
    }
}
