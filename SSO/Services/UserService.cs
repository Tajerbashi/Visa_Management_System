using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SSO.BaseSSO.Model;
using SSO.BaseSSO.Repository;
using SSO.Common;
using SSO.DatabaseApplication;
using SSO.Domains;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Services
{
    public class UserService : BaseServices<UserDTO>, IUserRepository
    {
        private UserManager<UserEntity> _userManager;
        private SignInManager<UserEntity> _signInManager;

        public UserService(DbContextApplication context, IMapper mapper, UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager) : base(context, mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public override Result<long, bool> Create(UserDTO entity)
        {
            var model = Mapper.Map<UserEntity>(entity);
            model.UserName = entity.UserName;
            var result = _userManager.CreateAsync(model, entity.Password).Result;
            if (result.Succeeded)
            {
                return new Result<long, bool>
                {
                    Data = model.Id,
                    Messages = ResponseMessage.Success(),
                    Success = true,
                };
            }
            else
            {
                return new Result<long, bool>
                {
                    Data = model.Id,
                    Messages = (string)ResponseMessage.MessageeLine(result.Errors),
                    Success = false,
                };
            }
        }

        public override Result<bool, bool> Delete(UserDTO entity)
        {
            throw new NotImplementedException();
        }

        public override Result<bool, bool> Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public Result<LoginDTO, SignInResult> Login(LoginDTO model)
        {
            try
            {
                var user = _userManager.FindByNameAsync(model.UserName).Result;
                _signInManager.SignOutAsync();
                var loginResult = _signInManager.PasswordSignInAsync(
                   user,
                   model.Password,
                   model.IsPersistance,
                   true
                   ).Result;
                if (loginResult.Succeeded)
                {
                    return new Result<LoginDTO, SignInResult>
                    {
                        Data = model,
                        Messages = ResponseMessage.Success(),
                        Results = loginResult,
                        Success = true,
                    };
                }
                return new Result<LoginDTO, SignInResult>
                {
                    Data = model,
                    Messages = ResponseMessage.FaildLogin(),
                    Results = loginResult,
                    Success = false,
                };
            }
            catch
            {
                throw;
            }

        }

        public override Result<UserDTO, bool> Read(long Id)
        {
            throw new NotImplementedException();
        }

        public override Result<List<UserDTO>, bool> ReadAll()
        {
            try
            {
                var model = Mapper.Map<List<UserDTO>>(Context.Users.ToList());
                return new Result<List<UserDTO>, bool>
                {
                    Data = model,
                    Messages = ResponseMessage.Success(),
                    Results = true,
                    Success = true,
                };
            }
            catch
            {
                return new Result<List<UserDTO>, bool> { Success = false };
            }
        }

        public Result<bool, bool> SignOut()
        {
            var res = _signInManager.SignOutAsync();
            return new Result<bool, bool>
            {
                Messages = ResponseMessage.SignOutSuccess(),
                Data = true,
                Success = true,
                Results = true,
            };
        }

        public override Result<bool, bool> Update(UserDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
