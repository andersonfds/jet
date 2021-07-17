using System;

namespace Commerce.Application.Core.DTO
{
    public class ProductResponseDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string PhotoUri { get; set; }
    }
}
