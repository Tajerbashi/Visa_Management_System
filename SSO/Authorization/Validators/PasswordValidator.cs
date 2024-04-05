using Microsoft.AspNetCore.Identity;
using SSO.Domains;

namespace SSO.Authorization.Validators
{
    public class PasswordValidator : IPasswordValidator<UserEntity>
    {
        public List<string> GeneralPassword = new List<string>
        {
            "123456",
            "1qaz!QAZ",
            "2wsx@WSX",
            "1234qwer",
            "10010001",
            "10101010",
            "11110000",
        };
        public Task<IdentityResult> ValidateAsync(UserManager<UserEntity> manager, UserEntity user, string password)
        {
            if (GeneralPassword.Contains(password))
            {
                var result = IdentityResult.Failed(new IdentityError
                {
                    Code="",
                    Description=""
                });
                return Task.FromResult(result);
            }
            return Task.FromResult(IdentityResult.Success);
        }
    }
}

