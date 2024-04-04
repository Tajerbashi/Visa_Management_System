using SSO.BaseSSO.Model;
using System.ComponentModel.DataAnnotations;

namespace SSO.Models.DTOs
{
    public class ForgotPasswordDTO : BaseDTO
    {
        //[BindProperty]
        //[Display(Name ="ایمیل")]
        [EmailAddress]
        [Required(ErrorMessage = "ایمیل اجباری است")]
        public string Email { get; set; }
        //[Display(Name ="رمز")]
        //[BindProperty]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "رمز اجباری است")]
        public string Password { get; set; }

        //[Display(Name ="تکرار رمز")]
        //[BindProperty]
        [Required(ErrorMessage = "رمز تکراری درست نیست")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
