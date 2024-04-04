using Microsoft.AspNetCore.Identity;
using SSO.BaseSSO.Model;
using SSO.BaseSSO.Repository;
using SSO.Models;
using SSO.Models.DTOs;
using System.Security.Claims;

namespace SSO.Repositpries
{
    public interface IUserRepository : IGenericRepository<UserDTO>
    {
        /// <summary>
        /// ورود درون برنامه ایی
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<Result<LoginDTO, bool>> LoginInternal(LoginDTO model);
        /// <summary>
        /// ورود به نرم افزار
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Result<LoginDTO, SignInResult> Login(LoginDTO model);
        /// <summary>
        /// خروج از نرم افزار
        /// </summary>
        /// <returns></returns>
        Result<bool, bool> SignOut();
        /// <summary>
        /// دریافت اطلاعات بر اساس ایمیل کاربر
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Result<SignUpDTO, string> ReadDataByEmail(string email);
        /// <summary>
        /// بازنشانی رمز
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        Result<SignUpDTO, bool> ResetPassword(SignUpDTO user,string token,string newPass);
        /// <summary>
        /// ایجاد توکن
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Result<string> GeneratToken(long userId);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Result<ClaimUser> AddClaim(ClaimUser claim);
        Result<ClaimUser> GetClaim(ClaimUser claim);
        Result<List<ClaimUser>> GetClaims(long UserId);
        Result<ClaimUser> UpdateClaim(ClaimUser claim);
        Result<bool> DeleteClaim(ClaimUser  claim);



    }
}
