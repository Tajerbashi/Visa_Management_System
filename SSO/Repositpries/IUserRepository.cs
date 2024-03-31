using Microsoft.AspNetCore.Identity;
using SSO.BaseSSO.Model;
using SSO.BaseSSO.Repository;
using SSO.Models.DTOs;

namespace SSO.Repositpries
{
    public interface IUserRepository : IGenericRepository<UserDTO>
    {
        Task<Result<LoginDTO, bool>> LoginInternal(LoginDTO model);
        Result<LoginDTO, SignInResult> Login(LoginDTO model);
        Result<bool, bool> SignOut();

        Result<string> GeneratToken(long userId);

    }
}
