using Commerce.Application.Core;
using Commerce.Application.Core.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginApp LoginApp;

        public LoginController(ILoginApp loginApp)
        {
            LoginApp = loginApp;
        }

        [HttpPost("session")]
        public IActionResult Login([FromBody] LoginRequestDTO request)
        {
            return Ok(LoginApp.Login(request));
        }
    }
}
