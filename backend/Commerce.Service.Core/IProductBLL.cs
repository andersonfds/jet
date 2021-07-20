using Commerce.Domain.Entity;
using System;
using System.Collections.Generic;

namespace Commerce.BLL.Core
{
    public interface IProductBLL
    {
        void Create(Product product);

        IEnumerable<Product> GetProductsCatalog();

        Product GetById(Guid id);
    }
}
