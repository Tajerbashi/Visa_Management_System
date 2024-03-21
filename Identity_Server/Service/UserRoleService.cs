using Identity_Server.Bases.Model;
using Identity_Server.Domain;
using Identity_Server.Repository;

namespace Identity_Server.Service
{
    public class UserRoleService : IUserRoleRepository
    {
        public Result<long> Create(UserRoleEntity entity)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Delete(UserRoleEntity entity)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public Result<UserRoleEntity> Read()
        {
            throw new NotImplementedException();
        }

        public Result<List<UserRoleEntity>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Result<bool> Update(UserRoleEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
