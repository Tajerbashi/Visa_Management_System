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
        [HttpGet]
        public IActionResult Index()
        {
            var data = userRepository.ReadAll();
            return View();
        }

        [HttpPost]
        public IActionResult SignUp([FromBody] SignUpDTO model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var entity = new UserDTO
            {
                Name = model.Name,
                Family = model.Family,
                UserName = model.UserName,
                Email = model.Email,
                IsActive=true,
                IsDeleted=false,
                Password= model.Password
            };
            var res = userRepository.Create(entity);
            if (res.Success)
            {
                return RedirectToPage("Index");
            }
            else
            {
                TempData["Errors"] = res.Results;
                return View(model);
            }
        }
    }
}
