using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace SSO.Helper
{
    public class AddClaimsExternal : IClaimsTransformation
    {
        public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            if (principal != null)
            {
                var identity = principal.Identity as ClaimsIdentity;
                if (identity != null)
                {
                    identity.AddClaim(new Claim("TestClaim","Yse",ClaimValueTypes.String));
                    identity.AddClaim(new Claim("Credit", "2000",ClaimValueTypes.String));
                }
            }
            return Task.FromResult(principal);
        }
    }
}
