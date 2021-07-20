using System;

namespace Commerce.Application.Core.DTO
{
    public class CartRequestDTO
    {
        public Guid ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
