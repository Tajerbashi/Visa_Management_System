using Microsoft.AspNetCore.Authorization;
using SSO.Models.DTOs;

namespace SSO.Authorization.Requirements.SelfAccessUser
{
    public class SelfAccessUserToBLogRequirement : IAuthorizationRequirement
    {
    }
    public class SelfAccessUserToBlogRequirementHandler : AuthorizationHandler<SelfAccessUserToBLogRequirement, BlogDTO>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, SelfAccessUserToBLogRequirement requirement, BlogDTO resource)
        {
            if (context.User.Identity?.Name == resource.UserName)
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }


}
