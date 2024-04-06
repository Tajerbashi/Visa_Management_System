using Microsoft.AspNetCore.Authorization;

namespace SSO.Authorization.Requirements.SelfAccessUser
{
    public class SelfAccessUserRequirement<T> : IAuthorizationRequirement
        where T : IRequirement
    { }


    public class SelfAccessUserRequirementHandler<T> : AuthorizationHandler<SelfAccessUserRequirement<T>, T>
        where T : IRequirement
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, SelfAccessUserRequirement<T> requirement, T resource)
        {
            if (context.User.Identity?.Name == resource.UserName)
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
    public interface IRequirement
    {
        string UserName { get; set; }
    }
}
