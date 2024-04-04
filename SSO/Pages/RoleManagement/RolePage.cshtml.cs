using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Pages.RoleManagement
{
    public class RolePageModel : PageModel
    {
        private readonly IRoleRepository roleRepository;
        [ModelBinder]
        public RoleDTO Role { get; set; } = default;

        public string Style { get; set; }
        public string Title { get; set; }

        public RolePageModel(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }
        public List<RoleDTO> Roles { get; set; }
        public void OnGet()
        {
            Style = "d-none";
            Roles = roleRepository.ReadAll().Data;
        }

        public void OnGetCreate()
        {
            Style = "";
            Title = "ایجاد نقش جدید";
            Roles = roleRepository.ReadAll().Data;
        }
        public void OnPostCreate()
        {
            var res = roleRepository.Create(Role);
            if (res.Success)
            {
                Roles = roleRepository.ReadAll().Data;
                Style = "d-none";
            }
            else
            {
                ViewData["Errors"] = res.Messages;
            }
        }
    }
}
