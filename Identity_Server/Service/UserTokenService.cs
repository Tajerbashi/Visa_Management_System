using Identity_Server.Bases.Model;
using Identity_Server.Domain;
using Identity_Server.Repository;

namespace Identity_Server.Service
{
    public class UserTokenService : IUserTokenRepository
    {
        public Result<long> Create(UserTokenEntity entity)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Delete(UserTokenEntity entity)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public Result<UserTokenEntity> Read()
        {
            throw new NotImplementedException();
        }

        public Result<List<UserTokenEntity>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Result<bool> Update(UserTokenEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
