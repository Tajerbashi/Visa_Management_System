using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SSO.Pages.Admin
{
    [Authorize(Roles ="Admin")]
    public class AdminPanelModel : PageModel
    {
        public void OnGet()
        {
        }
        public ViewType ViewType { get; set; } = ViewType.Admin;
        public IActionResult OnGetLoadUserView()
        {
            ViewType = ViewType.User;
            return ViewComponent("");
        }
        public IActionResult OnGetLoadRoleView()
        {
            ViewType = ViewType.Role;
            return ViewComponent("");
        }
        public IActionResult OnGetLoadPrivilegeView()
        {
            ViewType = ViewType.Privileges;
            return ViewComponent("");
        }

        public void OnPost() { }
    }
    public enum ViewType
    {
        Admin,
        User,
        Role,
        Privileges,
    }
}
