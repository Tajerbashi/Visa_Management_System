using Microsoft.AspNetCore.Mvc;
using SSO.BaseSSO.Model;
using System.ComponentModel.DataAnnotations;

namespace SSO.Models.DTOs
{
    public class SignUpDTO : BaseDTO
    {
        //[BindProperty]
        //[Display(Name ="نام")]
        [Required(ErrorMessage ="نام اجباری است")]
        public string Name { get; set; }

        //[BindProperty]
        //[Display(Name ="فامیلی")]
        [Required(ErrorMessage ="نام خانوادگی اجباری است")]
        public string Family { get; set; }

        //[BindProperty]
        //[Display(Name ="نام کاربری")]
        [Required(ErrorMessage ="نام کاربری اجباری است")]
        public string UserName { get; set; }

        //[BindProperty]
        //[Display(Name ="ایمیل")]
        [EmailAddress]
        [Required(ErrorMessage ="ایمیل اجباری است")]
        public string Email { get; set; }

        //[Display(Name ="رمز")]
        //[BindProperty]
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="رمز اجباری است")]
        public string Password { get; set; }

        //[Display(Name ="تکرار رمز")]
        //[BindProperty]
        [Required(ErrorMessage ="رمز تکراری درست نیست")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
