using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
        private readonly UserManager<UserEntity> userManager;
        public RoleService(
            DbContextApplication context, IMapper mapper,
            RoleManager<RoleEntity> roleManager,
            UserManager<UserEntity> userManager) : base(context, mapper)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public Result<bool> AddUserToRole(string role, long userID, bool isDefault = false)
        {
            try
            {
                // Add the Admin role to the database
                var roleEntity = roleManager.FindByNameAsync(role).Result;
                // Select the user, and then add the admin role to the user
                var user =  userManager.FindByIdAsync(userID.ToString()).Result;
                var roleExistForUser = Context.UserRoles.FirstOrDefault(x => x.UserId == userID && x.RoleId == roleEntity.Id);
                if (roleExistForUser == null)
                {
                    var userRole = new UserRoleEntity
                    {
                        UserId = user.Id,
                        RoleId=roleEntity.Id,
                        IsActive=true,
                        IsDefault=isDefault,
                        IsDeleted = false,
                    };
                    Context.UserRoles.Add(userRole);
                }
                else
                {
                    roleExistForUser.IsDeleted = false;
                    roleExistForUser.IsActive = true;
                    roleExistForUser.IsDefault = isDefault;
                    Context.UserRoles.Update(roleExistForUser);
                }
                Context.SaveChanges();
                return new Result<bool>
                {
                    Data = true,
                    Messages = ResponseMessage.Success(),
                    Success = true,
                };

            }
            catch
            {
                return new Result<bool>
                {
                    Data = false,
                    Messages = ResponseMessage.Faild(),
                    Success = false,
                };
            }
        }

        public Result<List<RoleDTO>> AllRolesByExistRoleUser(long userId)
        {
            var result = new Result<List<RoleDTO>>();
            result.Data = new List<RoleDTO>();
            var user = userManager.FindByIdAsync(userId.ToString()).Result;
            var roles = Mapper.Map<List<RoleDTO>>(roleManager.Roles);
            var userRoles = userManager.GetRolesAsync(user).Result;

            foreach (var role in roles)
            {
                if (userRoles.Any(x => x.Equals(role.Name)))
                {
                    role.Selected = true;
                }
                result.Data.Add(role);
            }
            return result;

        }

        public override Result<long, bool> Create(RoleDTO entity)
        {
            try
            {
                entity.IsDeleted = false;
                entity.IsActive = true;
                var model = Mapper.Map<RoleEntity>(entity);
                var result = roleManager.CreateAsync(model).Result;
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
            try
            {
                var model = Mapper.Map<RoleEntity>(entity);
                model.IsDeleted = true;
                model.IsActive = false;
                roleManager.UpdateAsync(model);
                return new Result<bool, bool>
                {
                    Data = true,
                    Messages = ResponseMessage.Success(),
                    Success = true,
                    Results = true
                };
            }
            catch
            {

                throw;
            }
        }

        public override Result<bool, bool> Delete(long ID)
        {
            try
            {
                var entity = roleManager.FindByIdAsync(ID.ToString()).Result;
                if (entity != null)
                    return this.Delete(Mapper.Map<RoleDTO>(entity));
                return new Result<bool, bool> { Success = false };
            }
            catch
            {
                throw;
            }
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
                    Results = true
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
                var model = Mapper.Map<List<RoleDTO>>(roleManager.Roles.Where(r => r.IsActive && !r.IsDeleted).ToList());
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

        public Result<List<UserRoleDTO>> RolesOfUser(long userId)
        {
            try
            {
                var user = userManager.FindByIdAsync(userId.ToString()).Result;
                var resultData = from ur in Context.UserRoles
                                 join ro in Context.Roles
                                 on ur.RoleId equals ro.Id
                                 select new UserRoleDTO
                                 {
                                     Id = ur.ID,
                                     RoleId = ro.Id,
                                     Name=ro.Name,
                                     Description=ro.Description,
                                     IsActive=ro.IsActive,
                                     IsDefault = ur.IsDefault,
                                     IsDeleted = ur.IsDeleted,
                                 };
                return new Result<List<UserRoleDTO>>
                {
                    Data = resultData.ToList(),
                    Messages = ResponseMessage.Success(),
                    Success = true,
                };
            }
            catch
            {
                throw;
            }
        }

        public override Result<bool, bool> Update(RoleDTO entity)
        {
            try
            {
                var res = roleManager.UpdateAsync(Mapper.Map<RoleEntity>(entity)).Result;
                if (res.Succeeded)
                {
                    return new Result<bool, bool>
                    {
                        Data = true,
                        Messages = ResponseMessage.Success(),
                        Success = true,
                        Results = true
                    };
                }
                return new Result<bool, bool>
                {
                    Data = false,
                    Messages = ResponseMessage.Faild(),
                    Success = false,
                    Results = false
                };
            }
            catch
            {

                throw;
            }
        }

        public Result<List<UserOfRoleDTO>> UsersOfRole(string role)
        {
            var result = userManager.GetUsersInRoleAsync(role).Result;
            return new Result<List<UserOfRoleDTO>>
            {
                Data = result.Select(x => new UserOfRoleDTO 
                { 
                    Id = x.Id,
                    Name = x.Name,
                    Family = x.Family,
                    Email = x.Email,
                    IsActive = x.IsActive,
                    IsDeleted = x.IsDeleted,
                    RoleName = x.Name,
                    UserName = x.UserName
                }).ToList(),
                Messages = ResponseMessage.Success(),
                Success = true,
            };
        }
    }
}
