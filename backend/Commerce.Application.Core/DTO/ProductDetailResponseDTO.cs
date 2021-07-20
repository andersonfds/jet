using System;

namespace Commerce.Application.Core.DTO
{
    public class ProductDetailResponseDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string PhotoUri { get; set; }

        public string Description { get; set; }
    }
}
