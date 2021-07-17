using Commerce.Domain.Entity;
using Commerce.Domain.Interfaces;
using System.Collections.Generic;

namespace Commerce.Repository.Core
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetProductsCatalog();
    }
}
