using Identity_Server.Bases.Model;
using Identity_Server.Domain;
using Identity_Server.Repository;

namespace Identity_Server.Service
{
    public class RoleClaimService : IRoleClaimRepository
    {
        public Result<long> Create(RoleClaimEntity entity)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Delete(RoleClaimEntity entity)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public Result<RoleClaimEntity> Read()
        {
            throw new NotImplementedException();
        }

        public Result<List<RoleClaimEntity>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Result<bool> Update(RoleClaimEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
