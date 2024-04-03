using SSO.BaseSSO.Model;

namespace SSO.Models.DTOs
{
    /// <summary>
    /// مدل کاربران نقش
    /// </summary>
    public class UserOfRoleDTO : BaseDTO
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Email { get; set; }
        public string RoleName { get; set; }

    }
}
