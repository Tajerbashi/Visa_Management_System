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
        private readonly UserManager < UserEntity > _userManager;
        private readonly SignInManager<UserEntity> _signInManager;

        public UserService(DbContextApplication context, IMapper mapper, UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager) : base(context, mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public override Result<long, bool> Create(UserDTO entity)
        {
            var model = Mapper.Map<UserEntity>(entity);
            model.UserName = entity.UserName;
            model.IsActive = true;
            model.IsDeleted = false;
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
            var user = _userManager.FindByIdAsync(entity.Id.ToString()).Result;
            user.IsDeleted = true;
            user.IsActive = false;
            var res = _userManager.UpdateAsync(user).Result;
            if (res.Succeeded)
            {
                return new Result<bool, bool>
                {
                    Data = true,
                    Messages = ResponseMessage.Success(),
                    Results = true,
                    Success = true
                };
            }
            return new Result<bool, bool>
            {
                Data = false,
                Messages = ResponseMessage.Faild(),
                Results = false,
                Success = false
            };
        }

        public override Result<bool, bool> Delete(long ID)
        {
            return Delete(new UserDTO
            {
                Id = ID,
                IsDeleted = false,
                IsActive = true
            });
        }

        public Result<string> GeneratToken(long userId)
        {
            try
            {
                var user= _userManager.FindByIdAsync(userId.ToString()).Result;
                var code = _userManager.GenerateEmailConfirmationTokenAsync(user).Result;
                return new Result<string>
                {
                    Data = code,
                    Messages = ResponseMessage.Success(),
                    Success = true,
                };
            }
            catch
            {
                throw;
            }
        }

        public async Task<Result<LoginDTO, bool>> LoginInternal(LoginDTO model)
        {
            try
            {
                var user = _userManager.FindByNameAsync(model.UserName).Result;
                await _signInManager.SignOutAsync();
                //var loginResult = _signInManager.SignInAsync(user,true);
                var loginResult = _signInManager.RefreshSignInAsync(user);
                Task.WaitAny(loginResult);
                if (loginResult.IsCompletedSuccessfully)
                {
                    return new Result<LoginDTO, bool>
                    {
                        Data = model,
                        Messages = ResponseMessage.Success(),
                        Results = true,
                        Success = true,
                    };
                }
                return new Result<LoginDTO, bool>
                {
                    Data = model,
                    Messages = ResponseMessage.FaildLogin(),
                    Results = false,
                    Success = false,
                };
            }
            catch
            {

                throw;
            }
        }
        public Result<LoginDTO, SignInResult> Login(LoginDTO model)
        {
            try
            {
                var user = _userManager.FindByNameAsync(model.UserName).Result;
                _signInManager.SignOutAsync();
                if (user == null)
                {
                    return new Result<LoginDTO, SignInResult>
                    {
                        Data=null,
                        Messages = ResponseMessage.NotFound(),
                        Results=null,
                        Success = false,
                    };
                }
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
            var entity = _userManager.FindByIdAsync(Id.ToString()).Result;
            var dto = Mapper.Map<UserDTO>(entity);
            return new Result<UserDTO, bool>
            {
                Data = dto,
                Messages = ResponseMessage.Success(),
                Results = true,
                Success = true
            };
        }

        public override Result<List<UserDTO>, bool> ReadAll()
        {
            try
            {
                var model = Mapper.Map<List<UserDTO>>(_userManager.Users.Where(x => x.IsActive && !x.IsDeleted).ToList());
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
            //vaMapper.Map<UserEntity>(entity);
            var model = _userManager.FindByIdAsync(entity.Id.ToString()).Result;
            model.Name = entity.Name;
            model.Family = entity.Family;
            model.Email = entity.Email;
            model.UserName = entity.UserName;

            var res = _userManager.UpdateAsync(model).Result;
            if (res.Succeeded)
            {

                return new Result<bool, bool>
                {
                    Data = true,
                    Success = true,
                    Messages = ResponseMessage.Success(),
                    Results = true,
                };
            }
            return new Result<bool, bool>
            {
                Data = false,
                Success = false,
                Messages = ResponseMessage.Faild(),
                Results = false,
            };

        }

        public Result<SignUpDTO, string> ReadDataByEmail(string email)
        {
            try
            {
                var model = _userManager.FindByEmailAsync(email).Result;
                if (model != null)
                {
                    return new Result<SignUpDTO, string>
                    {
                        Data = Mapper.Map<SignUpDTO>(model),
                        Messages = ResponseMessage.Success(),
                        Results = _userManager.GeneratePasswordResetTokenAsync(model).Result,
                        Success = true,
                    };
                }
                return new Result<SignUpDTO, string>
                {
                    Data = Mapper.Map<SignUpDTO>(model),
                    Messages = ResponseMessage.Faild(),
                    Results = ResponseMessage.EmptyModel(),
                    Success = false,
                };
            }
            catch
            {
                throw;
            }
        }

        public Result<SignUpDTO, bool> ResetPassword(SignUpDTO user, string token, string newPass)
        {
            var model = _userManager.FindByEmailAsync(user.Email).Result;
            var result = _userManager.ResetPasswordAsync(model,token,newPass).Result;
            if (result.Succeeded)
            {
                return new Result<SignUpDTO, bool>
                {
                    Data = user,
                    Messages = ResponseMessage.Success(),
                    Results = true,
                    Success = true,
                };
            }
            return new Result<SignUpDTO, bool>
            {
                Data=user,
                Messages = (string)ResponseMessage.MessageeLine(result.Errors),
                Results =false,
                Success = false,
            };
        }
    }
}
