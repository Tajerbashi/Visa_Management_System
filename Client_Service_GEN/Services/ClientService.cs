using Client_Service_GEN.Models;
using Client_Service_GEN.Repositories;

namespace Client_Service_GEN.Services
{
    public class ClientService : IClientRepository
    {
        public ResultModel<List<UserModel>> GetAllUsers()
        {
            var result = new List<UserModel>();
            for (int i = 1; i<= 10; i++)
            {
                result.Add(new UserModel { Id = i, Name = $"Client Name {i}", Family = $"Client Family {i}", Email = $"ClientEmail_{i}@mail.com", Password = $"@@@@{i}@@@@" });
            }
            return new ResultModel<List<UserModel>>
            {
                Data = result,
                Message = "",
                Status = true,
            };
        }
    }
}
