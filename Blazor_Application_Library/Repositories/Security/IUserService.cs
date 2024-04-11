using Blazor_Application_Library.Models.General;
using Blazor_Application_Library.Models.Security;

namespace Blazor_Application_Library.Repositories.Security
{
    public interface IUserService
    {
        Task<Result<bool>> Login(LoginDTO model);
        Task<Result<bool>> SignUp(SignUpDTO model);
        Task<Result<bool>> LogOut();
        Task<Result<long>> Create(UserDTO user);
        Task<Result<bool>> Update(UserDTO user);
        Task<Result<bool>> AddOrUpdate(UserDTO user);
        Task<Result<bool>> Remove(UserDTO user);
        Task<Result<bool>> Remove(long id);
        Task<Result<bool>> DisActive(long id);
        Task<Result<bool>> ChangeActive(long id);
        Task<Result<UserDTO>> Get(long id);
        Task<Result<List<UserDTO>>> Get();


    }
}
