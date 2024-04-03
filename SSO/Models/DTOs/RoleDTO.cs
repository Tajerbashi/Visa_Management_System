using SSO.BaseSSO.Model;

namespace SSO.Models.DTOs
{
    public class RoleDTO: BaseDTO
    {
        public string Description { get; set; }
        public string Name { get; set; }

        public bool Selected { get; set; }
    }
}
