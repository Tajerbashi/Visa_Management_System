using Client_Service_GEN.Models;

namespace Client_Service_GEN.ContextDB
{
    public class DataContextDB 
    {
        public List<UserModel> UserModels;
        public DataContextDB()
        {
            UserModels = User();

        }
        
        private List<UserModel> User()
        {
            var result = new List<UserModel>();
            for (int i = 1; i <= 10; i++)
            {
                result.Add(new UserModel { ID = i, Name = $"Client Name {i}", Family = $"Client Family {i}", Email = $"ClientEmail_{i}@mail.com", Password = $"@@@@{i}@@@@" ,Picture=$"a ({i}).jpg" });
            }
            return result;
        }
    }
}
