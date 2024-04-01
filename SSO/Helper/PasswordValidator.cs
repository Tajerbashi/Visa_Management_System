using Microsoft.AspNetCore.Identity;
using SSO.Domains;

namespace SSO.Helper
{
    public class PasswordValidator : IPasswordValidator<UserEntity>
    {
        public List<string> GeneralPassword { get; set; }
        public PasswordValidator()
        {
            GeneralPassword = new List<string>();

            GeneralPassword.Add("123456");
            GeneralPassword.Add("1qaz!QAZ");
            GeneralPassword.Add("2wsx@WSX");
            GeneralPassword.Add("1234qwer");
            GeneralPassword.Add("10010001");
            GeneralPassword.Add("10101010");
            GeneralPassword.Add("11110000");
        }
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
