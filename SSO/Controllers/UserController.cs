using Microsoft.AspNetCore.Mvc;
using SSO.BaseSSO.Controllers;

namespace SSO.Controllers
{
    public class UserController : BaseController
    {
        private readonly ILogger<UserController> logger;

        public UserController(ILogger<UserController> logger)
        {
            this.logger = logger;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }



    }
}
