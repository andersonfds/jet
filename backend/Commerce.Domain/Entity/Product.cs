using Commerce.Domain.Interfaces;

namespace Commerce.Domain.Entity
{
    public class Product : IEntity<Product>
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string PhotoUri { get; set; }

        public string Description { get; set; }
    }
}
