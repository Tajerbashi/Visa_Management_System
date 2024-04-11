using Blazor_Application_Library.Helpers;
using Blazor_Application_Library.Models.General;
using Blazor_Application_Library.Models.Security;
using Blazor_Application_Library.Repositories.Security;
using Blazor_Domain_Library.Entities.Security;
using Microsoft.AspNetCore.Identity;

namespace Blazor_Infrastructure_Library.Services.Security
{
    public class UserService : IUserService
    {
        private readonly UserManager<UserEntity> UserManager;
        private readonly SignInManager<UserEntity> SignInManager;

        public UserService(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }




        public Result<bool> AddOrUpdate(UserDTO user)
        {
            try
            {
                if (user.ID == 0)
                {
                    var result = Create(user);
                    return new Result<bool>
                    {

                    };
                }
                else
                {
                    var result = Update(user);
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

        public Result<bool> ChangeActive(long id)
        {
            try
            {

                return new Result<bool>
                {

                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Result<long> Create(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public Result<bool> DisActive(long id)
        {
            throw new NotImplementedException();
        }

        public Result<UserDTO> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Result<List<UserDTO>> Get()
        {
            throw new NotImplementedException();
        }
        public Result<bool> Login(LoginDTO model)
        {
            try
            {

                var userEntity = UserManager.FindByNameAsync(model.UserName).Result;
                var SignOut = SignInManager.SignOutAsync();
                if (userEntity is null)
                {
                    return new Result<bool>
                    {
                        Data = false,
                        IsSuccess = false,
                        Message = ApplicationMessages.NotFoundData(),
                        Response = ""
                    };
                }
                //var loginResult = SignInManager.PasswordSignInAsync(
                //   userEntity,
                //   model.Password,
                //   model.IsPersistence,
                //   true
                //   ).Result;

                var loginResult = SignInManager.RefreshSignInAsync(userEntity);
                Task.WaitAny(loginResult);
                if (loginResult.IsCompletedSuccessfully)
                {
                    return new Result<bool>
                    {
                        Data = true,
                        IsSuccess = true,
                        Message = ApplicationMessages.Success(),
                        Response = loginResult
                    };
                }

                return new Result<bool>
                {
                    Data = false,
                    IsSuccess = false,
                    Message = ApplicationMessages.FaildLogin(),
                    Response = loginResult
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Result<bool> LogOut()
        {
            try
            {

                return new Result<bool>
                {

                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Result<bool> Remove(UserDTO user)
        {
            try
            {
                return new Result<bool>
                {

                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Result<bool> Remove(long id)
        {
            throw new NotImplementedException();
        }

        public Result<bool> SignUp(SignUpDTO model)
        {
            try
            {
                var userEntity = new UserEntity
                {
                    Name = model.Name,
                    Family  = model.Family,
                    Email = model.Email,
                    UserName = model.UserName,
                    PhoneNumber=model.Phone,
                    IsActive = true,
                    IsDeleted = false
                };
                var result = UserManager.CreateAsync(userEntity,model.Password).Result;
                if (result.Succeeded)
                {
                    return new Result<bool>
                    {
                        Data = true,
                        IsSuccess = true,
                        Message = ApplicationMessages.Success(),
                    };
                }
                return new Result<bool>
                {
                    Data = false,
                    IsSuccess = false,
                    Message = "",
                    Response = (string)ApplicationMessages.IdentityErrors(result.Errors)
                };
            }
            catch
            {
                throw;
            }
        }

        public Result<bool> Update(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
