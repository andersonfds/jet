using Commerce.Application.Core;
using Commerce.Application.Core.DTO;
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

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserCreateRequestDTO userDto)
        {
            UserApp.Create(userDto);
            return Ok();
        }
    }
}
