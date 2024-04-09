using Blazor_Application_Library.ApplicationBase.Models;

namespace Blazor_Application_Library.Models.Security
{
    public class SignUpDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
    }
}
