using Commerce.Application.Core;
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
        public IActionResult CreateProduct()
        {
            Product.CreateProduct();
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var data = Product.GetProductsCatalog();
            return Ok(data);
        }
    }
}
