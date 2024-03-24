using Microsoft.AspNetCore.Mvc;
using SSO.BaseSSO.Controllers;
using SSO.Models.DTOs;

namespace SSO.Controllers
{
    public class SignUpController : BaseController
    {
        private readonly ILogger<LoginController> _logger;

        public SignUpController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("SignUp")]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(SignUpDTO model)
        {
            return View();
        }
    }
}
