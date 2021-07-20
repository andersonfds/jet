using Commerce.Application.Core.DTO;
using System;
using System.Collections.Generic;

namespace Commerce.Application.Core
{
    public interface IProductApp
    {
        IEnumerable<ProductResponseDTO> GetProductsCatalog();

        void CreateProduct(ProductRequestDTO product);

        ProductDetailResponseDTO GetOne(Guid id);
    }
}
