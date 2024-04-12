using Blazor_Application_Library.ApplicationBase.Models;

namespace Blazor_Application_Library.Models.Security
{
    public class HttpContextDTO : BaseDTO
    {
        public string ServiceName { get; set; }
        public string MethodName { get; set; }
        public DateTime Time { get; set; }
    }
    public class UserDTO : BaseDTO
    {
    }
}
