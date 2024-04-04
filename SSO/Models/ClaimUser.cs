using SSO.BaseSSO.Model;

namespace SSO.Models
{
    public class ClaimUser : BaseDTO
    {
        public string Type { get; set; }
        public string Value { get; set; }
        public string User { get; set; }
    }
}
