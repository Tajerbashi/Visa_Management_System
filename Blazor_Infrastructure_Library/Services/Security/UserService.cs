using Blazor_Application_Library.Models.General;
using Blazor_Application_Library.Models.Security;
using Blazor_Application_Library.Repositories.Security;
using Blazor_Domain_Library.Entities.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Blazor_Infrastructure_Library.Services.Security
{
    public class UserService : UserManager<UserEntity>, IUserService
    {
        public UserService(
            IUserStore<UserEntity> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<UserEntity> passwordHasher,
            IEnumerable<IUserValidator<UserEntity>> userValidators, IEnumerable<IPasswordValidator<UserEntity>> passwordValidators,
            ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<UserEntity>> logger) 
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
        }

        public async Task<Result<bool>> AddOrUpdate(UserDTO user)
        {
            try
            {
                if (user.ID == 0)
                {
                    var result = await Create(user);
                    return new Result<bool>
                    {

                    };
                }
                else
                {
                    var result = await Update(user);
                    return new Result<bool>
                    {

                    };
                }
            }
            catch (Exception ex)
            {

                throw new Exception();
            }
        }

        public async Task<Result<bool>> ChangeActive(long id)
        {
            try
            {
                await Task.CompletedTask;
                return new Result<bool>
                {

                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<Result<long>> Create(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public Task<Result<bool>> DisActive(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<UserDTO>> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<UserDTO>>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<Result<bool>> Login(LoginDTO model)
        {
            try
            {
                await Task.CompletedTask;
                return new Result<bool>
                {
                    Data = true,
                    IsSuccess = true
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Result<bool>> LogOut()
        {
            try
            {
                await Task.CompletedTask;
                return new Result<bool>
                {

                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Result<bool>> Remove(UserDTO user)
        {
            try
            {
                await Task.CompletedTask;
                return new Result<bool>
                {

                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<Result<bool>> Remove(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<bool>> SignUp(SignUpDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<Result<bool>> Update(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
