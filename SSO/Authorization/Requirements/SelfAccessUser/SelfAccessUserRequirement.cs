using Microsoft.AspNetCore.Authorization;
using SSO.Models.DTOs;

namespace SSO.Authorization.Requirements.SelfAccessUser
{
    public class SelfAccessUserRequirement : IAuthorizationRequirement
    {
    }
    public class SelfAccessUserRequirementHandler : AuthorizationHandler<SelfAccessUserRequirement, BlogDTO>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, SelfAccessUserRequirement requirement, BlogDTO resource)
        {
            if (context.User.Identity?.Name == resource.UserName)
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
