using SSO.BaseSSO.Model;
using SSO.BaseSSO.Repository;
using SSO.Models.DTOs;

namespace SSO.Repositpries
{
    public interface IUserRepository:IGenericRepository<UserDTO>
    {
        Result<bool> Login(LoginDTO model);
    }
}
