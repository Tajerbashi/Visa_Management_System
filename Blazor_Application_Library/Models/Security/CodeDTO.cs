using Blazor_Application_Library.ApplicationBase.Models;

namespace Blazor_Application_Library.Models.Security
{
    public class CodeDTO : BaseDTO
    {
        public string Digit1 { get; set; }
        public string Digit2 { get; set; }
        public string Digit3 { get; set; }
        public string Digit4 { get; set; }
        public string Digit5 { get; set; }
    }
}
