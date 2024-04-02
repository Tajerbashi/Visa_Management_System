using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SSO.Pages.UserManagement
{
    public class RolesOfUserPageModel : PageModel
    {
        [BindProperty]
        public string Id { get; set; }
        public void OnGet(string id)
        {
            this.Id = id;
        }
    }
}
