using Microsoft.AspNetCore.Authorization;

namespace SSO.Authorization.Requirements.Credit
{
    public class CreditRequirement : IAuthorizationRequirement
    {
        public int Credit { get; set; }
        public CreditRequirement(int credit)
        {
            Credit = credit;
        }
    }
    public class CreditRequirementHandler : AuthorizationHandler<CreditRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CreditRequirement requirement)
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
