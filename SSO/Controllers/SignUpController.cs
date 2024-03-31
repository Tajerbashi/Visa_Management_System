using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SSO.BaseSSO.Controllers;
using SSO.DatabaseApplication;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Controllers
{
    public class SignUpController : BaseController
    {
        private readonly IUserRepository userRepository;
        private readonly ILogger<SignUpController> _logger;

        public SignUpController(
            ILogger<SignUpController> logger,
            DbContextApplication context,
            IUserRepository userRepository)
        {
            _logger = logger;
            this.userRepository = userRepository;
        }

        // GET: SignUp
        public async Task<IActionResult> Index()
        {
            await Task.CompletedTask;
            var res = userRepository.ReadAll();
            return View(res.Data);
        }
    }
}