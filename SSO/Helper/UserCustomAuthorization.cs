using Microsoft.AspNetCore.Authorization;

namespace SSO.Helper
{
    public class UserCustomAuthorization : IAuthorizationRequirement
    {
        public int Credit { get; set; }
        public UserCustomAuthorization(int credit)
        {
            Credit = credit;
        }


    }

    public class UserCustomCreditHandler : AuthorizationHandler<UserCustomAuthorization>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, UserCustomAuthorization requirement)
        {
            var claim = context.User.FindFirst("Credit");
            if (claim != null)
            {
                int credit = int.Parse(claim?.Value);
                if (credit >= requirement.Credit)
                {
                    context.Succeed(requirement);
                }
            }
            return Task.CompletedTask;
        }
    }

}
