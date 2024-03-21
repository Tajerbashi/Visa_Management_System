using Identity_Server.Bases.Model;
using Identity_Server.Domain;
using Identity_Server.Repository;

namespace Identity_Server.Service
{
    public class UserLoginService : IUserLoginRepository
    {
        public Result<long> Create(UserLoginEntity entity)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Delete(UserLoginEntity entity)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public Result<UserLoginEntity> Read()
        {
            throw new NotImplementedException();
        }

        public Result<List<UserLoginEntity>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Result<bool> Update(UserLoginEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
