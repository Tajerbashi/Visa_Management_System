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

        public override Result<long> Create(UserDTO entity)
        {
            var model = Mapper.Map<UserEntity>(entity);
            model.UserName = entity.UserName;
            var result = _userManager.CreateAsync(model, entity.Password).Result;
            if (result.Succeeded)
            {
                return new Result<long>
                {
                    Data = model.Id,
                    Messages = ResponseMessage.Success(),
                    Success = true,
                };
            }
            else
            {
                return new Result<long>
                {
                    Data = model.Id,
                    Messages = (string)ResponseMessage.MessageeLine(result.Errors),
                    Success = false,
                };
            }
        }

        public override Result<bool> Delete(UserDTO entity)
        {
            throw new NotImplementedException();
        }

        public override Result<bool> Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Login(LoginDTO model)
        {

            if (model.Id > 0)
            {
                return new Result<bool>
                {

                };
            }
            return new Result<bool>
            {

            };

        }

        public override Result<UserDTO> Read(long Id)
        {
            throw new NotImplementedException();
        }

        public override Result<List<UserDTO>> ReadAll()
        {
            try
            {
                var model = Mapper.Map<List<UserDTO>>(Context.Users.ToList());
                return new Result<List<UserDTO>>
                {
                    Data = model,
                    Results = ResponseMessage.Success(),
                    Success = true,
                };
            }
            catch
            {
                return new Result<List<UserDTO>> { Success = false };
            }
        }

        public override Result<bool> Update(UserDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
