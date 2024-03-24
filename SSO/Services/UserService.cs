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
    public class UserService :BaseServices<UserDTO>, IUserRepository
    {
        private UserManager<UserEntity> _userManager;

        public UserService(DbContextApplication context, IMapper mapper, UserManager<UserEntity> userManager) : base(context, mapper)
        {
            _userManager = userManager;
        }

        public override Result<long> Create(UserDTO entity)
        {
            throw new NotImplementedException();
        }

        public override Result<bool> Delete(UserDTO entity)
        {
            throw new NotImplementedException();
        }

        public override Result<bool> Delete(long ID)
        {
            throw new NotImplementedException();
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
