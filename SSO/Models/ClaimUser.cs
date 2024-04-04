using SSO.BaseSSO.Model;
using System.Security.Claims;

namespace SSO.Models
{
    public class ClaimUser : BaseDTO
    {
        public string Type { get; set; }
        public string Value { get; set; }
        public string User { get; set; }
        public List<Claim> Claims { get; set; }
    }
}
