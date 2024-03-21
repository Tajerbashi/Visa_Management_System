using Identity_Server.Bases.Controllers;
using Identity_Server.Bases.Model;
using Identity_Server.Domain;
using Identity_Server.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Identity_Server.Controllers
{

    public class UserController : BaseController
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserRepository _userRepository;

        public UserController(
            ILogger<UserController> logger,
            IUserRepository userRepository
            )
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        [HttpPost(Name = "Create")]
        public Result<long> Create(UserEntity entity)
        {
            return new Result<long>
            {
            };
        }
        [HttpGet(Name = "Get")]
        public Result<UserEntity> Read()
        {
            return new Result<UserEntity>
            {
            };
        }
        [HttpPut(Name = "Update")]
        public Result<long> Update(UserEntity entity)
        {
            return new Result<long>
            {
            };
        }
        [HttpDelete(Name = "Delete")]
        public Result<bool> Delete(long Id)
        {
            return new Result<bool>
            {
            };
        }
    }
}
