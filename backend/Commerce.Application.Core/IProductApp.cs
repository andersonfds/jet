using Commerce.Application.Core.DTO;
using Commerce.Domain.Entity;
using System.Collections.Generic;

namespace Commerce.Application.Core
{
    public interface IProductApp
    {
        IEnumerable<ProductResponseDTO> GetProductsCatalog();

        void CreateProduct();
    }
}
