using SSO.BaseSSO.Model;

namespace SSO.Models.DTOs
{
    public class UserRoleDTO: BaseDTO
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public long RoleId { get; set; }
    }
}
