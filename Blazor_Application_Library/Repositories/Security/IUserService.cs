using Blazor_Application_Library.Models.General;
using Blazor_Application_Library.Models.Security;

namespace Blazor_Application_Library.Repositories.Security
{
    public interface IUserService
    {
        Result<bool> Login(LoginDTO model);
        Result<bool> SignUp(SignUpDTO model);
        Result<bool> LogOut();
        Result<long> Create(UserDTO user);
        Result<bool> Update(UserDTO user);
        Result<bool> AddOrUpdate(UserDTO user);
        Result<bool> Remove(UserDTO user);
        Result<bool> Remove(long id);
        Result<bool> DisActive(long id);
        Result<bool> ChangeActive(long id);
        Result<UserDTO> Get(long id);
        Result<List<UserDTO>> Get();


    }
}
