using mcfbackend.Context;
using mcfbackend.Models;
using mcfbackend.Service;
using Microsoft.AspNetCore.Mvc;

namespace mcfbackend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly LoginService _loginService;

        public LoginController(McfDbContext context)
        {
            _loginService = new LoginService(context);
        }
        [HttpPost("Login")]
        public ActionResult Login(Ms_user adv)
        {
            var response = _loginService.CheckUserlogin(adv);
            if (response == "OK")
            {
                return Ok("Login Berhasil");

            }
            else
            {
                return BadRequest(response);

            }

        }
    }
}
