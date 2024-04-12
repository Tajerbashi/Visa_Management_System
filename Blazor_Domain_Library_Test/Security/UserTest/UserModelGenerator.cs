using Blazor_Domain_Library.Entities.Security;

namespace Blazor_Domain_Library_Test.Security.UserTest
{
    public class UserModelGenerator
    {
        public UserEntity GetUserEntity()
        {
            return new UserEntity()
            {
                Name = "Name User",
                Family = "Family User",
                IsActive = true,
                IsDeleted = false,
            };
        }
        public UserEntity GetUserEntityForUpdate()
        {
            return new UserEntity()
            {
                Name = "Name User Update",
                Family = "Family User Update",
                IsActive = true,
                IsDeleted = false,
            };
        }
    }
}
