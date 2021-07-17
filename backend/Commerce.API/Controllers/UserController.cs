using Commerce.Application.Core;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserApp UserApp;

        public UserController(IUserApp userApp)
        {
            UserApp = userApp;
        }

        [HttpGet("me/cart")]
        public IActionResult GetMyCart()
        {
            UserApp.GetMyCart();
            return Ok();
        }
    }
}
