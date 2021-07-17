using Commerce.Data.Core.DbContexts;
using Commerce.Data.Repository;
using Commerce.Domain.Entity;
using Commerce.Repository.Core;
using System.Collections.Generic;
using System.Linq;

namespace Commerce.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IAppDbContext context) : base(context)
        {
        }

        public IEnumerable<Product> GetProductsCatalog()
        {
            var query = from p in Context.GetEntity<Product>()
                        select p;

            return query.AsEnumerable();            
        }
    }
}
