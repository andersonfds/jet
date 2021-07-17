using Commerce.Domain.Entity;
using System.Collections.Generic;

namespace Commerce.BLL.Core
{
    public interface IProductBLL
    {
        void Create(Product product);

        IEnumerable<Product> GetProductsCatalog();
    }
}
