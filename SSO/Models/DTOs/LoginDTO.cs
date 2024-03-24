using SSO.BaseSSO.Model;
using System.ComponentModel.DataAnnotations;

namespace SSO.Models.DTOs
{
    public class LoginDTO : BaseDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
    }
}
