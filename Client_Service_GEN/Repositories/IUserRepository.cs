using Client_Service_GEN.Bases.Repository;
using Client_Service_GEN.Models;

namespace Client_Service_GEN.Repositories
{
    public interface IUserRepository:IBaseRepository<UserModel>
    {
        ResultModel<List<UserModel>> GetAllUsers();
    }
}
