using Blazor_Application_Library.ApplicationBase.Models;

namespace Blazor_Application_Library.Models.Security
{
    public class LoginDTO : BaseDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsPersistence { get; set; }
    }
}
