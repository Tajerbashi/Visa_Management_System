using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Models.DTOs;

namespace SSO.Pages.Identity
{
    public class ProfilePageModel : PageModel
    {
        [ModelBinder]
        public UserDTO User { get; set; }
        public void OnGet(string name)
        {
        }
    }
}
