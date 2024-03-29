using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Models.DTOs;

namespace SSO.Pages.Identity
{
    public class ForgotPasswordModel : PageModel
    {
        [ModelBinder]
        public SignUpDTO Model { get; set; }

        public void OnGet()
        {
        }

        public void OnPost() { }

    }
}
