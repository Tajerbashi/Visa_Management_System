using Microsoft.AspNetCore.Mvc;
using SSO.BaseSSO.Controllers;
using SSO.Models.DTOs;

namespace SSO.Controllers
{
    public class ProfileController : BaseController
    {
        private readonly ILogger<ProfileController> _logger;

        public ProfileController(ILogger<ProfileController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Profile")]
        public IActionResult Profile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Profile(ProfileDTO model)
        {
            return View();
        }

    }
}
