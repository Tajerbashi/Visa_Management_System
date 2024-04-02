using SSO.BaseSSO.Model;
using SSO.BaseSSO.Repository;
using SSO.Models.DTOs;

namespace SSO.Repositpries
{
    public interface IRoleRepository : IGenericRepository<RoleDTO>
    {
        /// <summary>
        /// اضافه کردن نقش به کاربر
        /// </summary>
        /// <param name="role"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        Result<bool> AddUserToRole(string role, long userID);
        /// <summary>
        /// کاربران نقش مورد نظر
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        Result<List<UserDTO>> UsersOfRole(string role);
        /// <summary>
        /// نقش های کاربران مورد نظر
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Result<List<RoleDTO>> RolesOfUser(long userId);
    }
}
