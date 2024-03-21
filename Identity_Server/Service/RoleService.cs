using Identity_Server.Bases.Model;
using Identity_Server.Domain;
using Identity_Server.Repository;

namespace Identity_Server.Service
{
    public class RoleService : IRoleRepository
    {
        public Result<long> Create(RoleEntity entity)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Delete(RoleEntity entity)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public Result<RoleEntity> Read()
        {
            throw new NotImplementedException();
        }

        public Result<List<RoleEntity>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Result<bool> Update(RoleEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
