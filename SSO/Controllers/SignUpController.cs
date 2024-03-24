using Microsoft.AspNetCore.Mvc;
using SSO.BaseSSO.Controllers;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Controllers
{
    public class SignUpController : BaseController
    {
        private readonly ILogger<LoginController> _logger;
        private readonly IUserRepository userRepository;
        public SignUpController(ILogger<LoginController> logger, IUserRepository userRepository)
        {
            _logger = logger;
            this.userRepository = userRepository;
        }

        public IActionResult Index()
        {
            var data = userRepository.ReadAll();
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
