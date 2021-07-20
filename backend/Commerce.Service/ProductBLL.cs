using Commerce.BLL.Core;
using Commerce.Domain.Entity;
using Commerce.Repository.Core;
using System;
using System.Collections.Generic;

namespace Commerce.BLL
{
    public class ProductBLL : IProductBLL
    {
        protected readonly IProductRepository Repository;

        public ProductBLL(IProductRepository repository)
        {
            Repository = repository;
        }

        public void Create(Product product)
        {
            Repository.Add(product);
        }

        public Product GetById(Guid id)
        {
            return Repository.Find(id);
        }

        public IEnumerable<Product> GetProductsCatalog()
        {
            return Repository.GetProductsCatalog();
        }
    }
}
