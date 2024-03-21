using Identity_Server.Bases.Model;
using Identity_Server.Domain;
using Identity_Server.Repository;

namespace Identity_Server.Service
{
    public class UserClaimService : IUserClaimRepository
    {
        public Result<long> Create(UserClaimEntity entity)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Delete(UserClaimEntity entity)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public Result<UserClaimEntity> Read()
        {
            throw new NotImplementedException();
        }

        public Result<List<UserClaimEntity>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Result<bool> Update(UserClaimEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
