using SSO.Authorization.Requirements.SelfAccessUser;

namespace SSO.Models
{
    public class UserData : IRequirement
    {
        public string UserName { get; set; }
        public string DefaultUserRole { get; set; }
    }
}
