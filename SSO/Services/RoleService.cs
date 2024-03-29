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
    public class RoleService : BaseServices<RoleDTO>, IRoleRepository
    {
        private readonly RoleManager<RoleEntity> roleManager;
        public RoleService(DbContextApplication context, IMapper mapper, RoleManager<RoleEntity> roleManager) : base(context, mapper)
        {
            this.roleManager = roleManager;
        }

        public override Result<long, bool> Create(RoleDTO entity)
        {
            try
            {
                var model = Mapper.Map<RoleEntity>(entity);
                var result =roleManager.CreateAsync(model).Result;
                if (result.Succeeded)
                {
                    return new Result<long, bool>
                    {
                        Data = model.Id,
                        Messages = ResponseMessage.Success(),
                        Success = true,
                    };
                }
                return new Result<long, bool>
                {
                    Data = 0,
                    Messages = (string)ResponseMessage.MessageeLine(result.Errors),
                    Success = false,
                };

            }
            catch
            {
                return new Result<long, bool> { Success = false };
            }
        }

        public override Result<bool, bool> Delete(RoleDTO entity)
        {
            throw new NotImplementedException();
        }

        public override Result<bool, bool> Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public override Result<RoleDTO, bool> Read(long Id)
        {
            try
            {
                var model = Mapper.Map<RoleDTO>(Context.Roles.Find(Id));
                return new Result<RoleDTO, bool>
                {
                    Data = model,
                    Messages = ResponseMessage.Success(),
                    Success = true,
                };
            }
            catch
            {
                return new Result<RoleDTO, bool> { Success = false };
            }
        }

        public override Result<List<RoleDTO>, bool> ReadAll()
        {
            try
            {
                var model = Mapper.Map<List<RoleDTO>>(roleManager.Roles.ToList());
                return new Result<List<RoleDTO>, bool>
                {
                    Data = model,
                    Messages = ResponseMessage.Success(),
                    Success = true,
                };
            }
            catch
            {
                return new Result<List<RoleDTO>, bool> { Success = false };
            }
        }

        public override Result<bool, bool> Update(RoleDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
