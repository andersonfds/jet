using Commerce.Domain.Interfaces;
using System.Collections.Generic;

namespace Commerce.Domain.Entity
{
    public class Product : IEntity<Product>
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string PhotoUri { get; set; }

        public virtual ICollection<UserCart> UsersCart { get; set; }
    }
}
