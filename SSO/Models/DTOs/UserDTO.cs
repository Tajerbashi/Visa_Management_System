using SSO.BaseSSO.Model;

namespace SSO.Models.DTOs
{
    public class UserDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public RoleDTO Role { get; set; }
        public List<RoleDTO> Roles { get; set; }
    }
}
