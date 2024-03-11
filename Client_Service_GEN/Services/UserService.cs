using Client_Service_GEN.Bases.Repository;
using Client_Service_GEN.Models;
using Client_Service_GEN.Repositories;

namespace Client_Service_GEN.Services
{
    public class UserService : BaseRepository<UserModel>, IUserRepository
    {
        public ResultModel<List<UserModel>> GetAllUsers()
        {
            return new ResultModel<List<UserModel>>
            {
                Data = DataContextDB.UserModels,
                Message = "عملیات با موفقیت انجام شد",
                Status = true,
            };
        }
    }
}
