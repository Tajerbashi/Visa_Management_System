using SSO.BaseSSO.Model;

namespace SSO.Models.DTOs
{
    /// <summary>
    /// مدل نقش های کاربر
    /// </summary>
    public class RoleOfUser : BaseDTO
    {
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public string UserName { get; set; }
        public bool Selected { get; set; }
    }
}
