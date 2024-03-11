using Client_Service_GEN.Models;

namespace Client_Service_GEN.Repositories
{
    public interface IClientRepository
    {
        ResultModel<List<UserModel>> GetAllUsers();

    }
}
