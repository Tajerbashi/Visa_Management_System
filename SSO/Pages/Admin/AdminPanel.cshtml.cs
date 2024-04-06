using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Models;
using SSO.Models.DTOs;

namespace SSO.Pages.Admin
{
    [Authorize(Roles ="Admin")]
    public class AdminPanelModel : PageModel
    {
        [BindProperty]
        public UserData UserData { get; set; } = default!;
        public void OnGet()
        {
            UserData = new UserData();
            var adminRole = User.Claims.Where(x => x.Type.Contains("Admin")).FirstOrDefault();
            if (adminRole != null)
            {

                UserData.DefaultUserRole = adminRole.Value;
                UserData.UserName = User.Identity.Name;
            }
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
