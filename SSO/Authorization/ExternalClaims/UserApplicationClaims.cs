using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using SSO.Domains;
using System.Security.Claims;

namespace SSO.Authorization.ExternalClaims
{
    public class UserApplicationClaims : UserClaimsPrincipalFactory<UserEntity>
    {
        public UserApplicationClaims
            (
            UserManager<UserEntity> userManager,
            IOptions<IdentityOptions> options)
            : base(userManager, options)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(UserEntity user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("FullName", $"{user.Name} - {user.Family}"));
            return identity;
        }

    }
}
