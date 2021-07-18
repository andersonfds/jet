using Commerce.Application.Core;
using Commerce.Application.Core.DTO;
using Commerce.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductApp Product;

        public ProductController(IProductApp product)
        {
            Product = product;
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductRequestDTO productDto)
        {
            Product.CreateProduct(productDto);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = Product.GetProductsCatalog();
            return Ok(products);
        }
    }
}
