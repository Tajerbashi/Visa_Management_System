using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SSO.Pages.Identity
{
    [AllowAnonymous]
    public class NotAccessPageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
