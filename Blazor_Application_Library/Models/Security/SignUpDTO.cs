using Blazor_Application_Library.ApplicationBase.Models;
using System.ComponentModel.DataAnnotations;

namespace Blazor_Application_Library.Models.Security
{
    public class SignUpDTO : BaseDTO
    {
        [Required(ErrorMessage ="نام را وارد کنید")]
        public string Name { get; set; }
       
        [Required(ErrorMessage = "فامیل را وارد کنید")]
        public string Family { get; set; }
        
        [Required(ErrorMessage = "نام کاربری را وارد کنید")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "ایمیل را وارد کنید")]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "تلفن را وارد کنید")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "رمز را وارد کنید")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "تکرار رمز را وارد کنید")]
        [Compare(nameof(Password),ErrorMessage ="رمز همخوانی ندارد")]
        [DataType(DataType.Password)]
        public string PasswordConfirmation { get; set; }
    }
}
