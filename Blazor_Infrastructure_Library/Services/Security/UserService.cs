using Blazor_Application_Library.Helpers;
using Blazor_Application_Library.Models.General;
using Blazor_Application_Library.Models.Security;
using Blazor_Application_Library.Repositories.Security;
using Blazor_Domain_Library.Entities.Security;
using Blazor_Domain_Library.Entities.Test;
using Blazor_Infrastructure_Library.DatabaseContext;
using Microsoft.AspNetCore.Identity;

namespace Blazor_Infrastructure_Library.Services.Security
{
    public class UserService : IUserService
    {
        private readonly UserManager<UserEntity> UserManager;
        private readonly SignInManager<UserEntity> SignInManager;
        private readonly DbContextApplication Context;

        public UserService(
            UserManager<UserEntity> userManager,
            SignInManager<UserEntity> signInManager,
            DbContextApplication context)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            Context = context;
        }

        public Result<int> AddLog(HttpContextDTO model)
        {
            var entity = new Person
            {
                Guid=Guid.NewGuid(),
                Age=10,
                Name=model.ServiceName,
                Family=model.MethodName,
                Sex=1,
                Email="",
                Phone="",
                Username=model.Time.ToString(),
                Password="",
                Re_Password="",
            };
            Context.People.Add(entity);
            Context.SaveChanges();
            return new Result<int>
            {
                Data = 1,
                IsSuccess = true,
                Message = ApplicationMessages.Success(),
                Response = "",
            };
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
        public async Task<Result<bool>> Login(LoginDTO model)
        {
            try
            {
                if (model.UserName is null || model.Password is null)
                {
                    return new Result<bool>
                    {
                        Data = false,
                        IsSuccess = false,
                        Message = ApplicationMessages.NotValidData(),
                    };
                }
                var user =  UserManager.FindByNameAsync(model.UserName).Result;
                if (user is null)
                {
                    return new Result<bool>
                    {
                        Data = false,
                        IsSuccess = false,
                        Message = ApplicationMessages.NotFoundData(),
                    };
                }
                if (await UserManager.CheckPasswordAsync(user, model.Password) == false)
                {
                    return new Result<bool>
                    {
                        Data = false,
                        IsSuccess = false,
                        Message = ApplicationMessages.WrongPassword(),
                    };

                }
                await SignInManager.SignInAsync(user, model.IsPersistence);
                return new Result<bool>
                {
                    Data = true,
                    IsSuccess = true,
                    Message = ApplicationMessages.Success(),
                    Response = ""
                };
                var result = await SignInManager.PasswordSignInAsync(model.UserName, model.Password, model.IsPersistence, true);

                if (result.Succeeded)
                {
                    return new Result<bool>
                    {
                        Data = true,
                        IsSuccess = true,
                        Message = ApplicationMessages.Success(),
                        Response = result
                    };
                }

                return new Result<bool>
                {
                    Data = false,
                    IsSuccess = false,
                    Message = ApplicationMessages.FaildLogin(),
                    Response = result
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
                var res = SignInManager.SignOutAsync();
                Task.WaitAny(res);
                return new Result<bool>
                {
                    Data = true,
                    IsSuccess = true,
                    Message = ApplicationMessages.Success()
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
