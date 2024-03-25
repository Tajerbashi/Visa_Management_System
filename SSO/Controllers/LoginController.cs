using Microsoft.AspNetCore.Mvc;
using SSO.BaseSSO.Controllers;
using SSO.Models.DTOs;

namespace SSO.Controllers
{
    public class LoginController : BaseController
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("Login")]
        [HttpPost]
        public IActionResult Login(LoginDTO model)
        {
            return View();
        }
    }
}
