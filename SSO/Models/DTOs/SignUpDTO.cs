using Microsoft.AspNetCore.Mvc;
using SSO.BaseSSO.Model;
using System.ComponentModel.DataAnnotations;

namespace SSO.Models.DTOs
{
    public class SignUpDTO : BaseDTO
    {
        [BindProperty]
        [Required(ErrorMessage ="نام اجباری است")]
        [Display(Name ="نام")]
        public string Name { get; set; }

        [BindProperty]
        [Required(ErrorMessage ="نام خانوادگی اجباری است")]
        [Display(Name ="فامیلی")]
        public string Family { get; set; }

        [BindProperty]
        [Required(ErrorMessage ="نام کاربری اجباری است")]
        [Display(Name ="نام کاربری")]
        public string UserName { get; set; }

        [BindProperty]
        [Required(ErrorMessage ="ایمیل اجباری است")]
        [EmailAddress]
        [Display(Name ="ایمیل")]
        public string Email { get; set; }

        [Required(ErrorMessage ="رمز اجباری است")]
        [BindProperty]
        [DataType(DataType.Password)]
        [Display(Name ="رمز")]
        public string Password { get; set; }

        [BindProperty]
        [Required(ErrorMessage ="رمز تکراری درست نیست")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        [Display(Name ="تکرار رمز")]
        public string ConfirmPassword { get; set; }
    }
}
