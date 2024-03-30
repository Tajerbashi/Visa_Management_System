using Microsoft.AspNetCore.Identity;
using SSO.BaseSSO.Model;
using SSO.BaseSSO.Repository;
using SSO.Models.DTOs;

namespace SSO.Repositpries
{
    public interface IUserRepository : IGenericRepository<UserDTO>
    {
        Result<LoginDTO, SignInResult> Login(LoginDTO model);
        Result<bool, bool> SignOut();

        Result<string> GeneratToken(long userId);

    }
}
