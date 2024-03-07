using Identity_External.Model;
using Microsoft.AspNetCore.Mvc;

namespace Identity_External.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetData")]
        public IEnumerable<UserModel> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new UserModel
            {
                Id = Random.Shared.Next(-20, 55),
                Name = Summaries[Random.Shared.Next(Summaries.Length)],
                Dateonly = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            })
            .ToArray();
        }
    }
}
