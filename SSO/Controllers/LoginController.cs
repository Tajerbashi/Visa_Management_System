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
        [HttpGet("Report")]
        public async Task<string> Report(CancellationToken cancellationToken)
        {
            var startTime = DateTime.Now;
            _logger.LogInformation($"Starting Request : {DateTime.Now}");
            for (int i = 0; i < 5; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                _logger.LogInformation(i.ToString());
                if (!cancellationToken.IsCancellationRequested)
                {
                    _logger.LogInformation($"cancellationToken.IsCancellationRequested : {cancellationToken.IsCancellationRequested}");
                }
                await Task.Delay(1000, cancellationToken);
            }
            _logger.LogInformation($"Finished Request : {DateTime.Now}");
            var endTime = DateTime.Now;
            var message = $"Start Time :  {startTime} \nEnd Time :  {endTime}";
            return message;
        }
        [Route("Login")]
        [HttpPost]
        public IActionResult Login(LoginDTO model)
        {
            return View();
        }
    }
}
