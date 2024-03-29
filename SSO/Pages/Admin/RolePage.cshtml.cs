using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Pages.Admin
{
    public class RolePageModel : PageModel
    {
        private readonly IRoleRepository roleRepository ;

        public RolePageModel(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }
        public List<RoleDTO> Roles { get; set; }
        public RoleDTO RoleEntity { get; set; }
        public void OnGet()
        {
            //roleRepository.Create(new RoleDTO
            //{
            //    Name = "Admin",
            //    Description = "ادمین",
            //    IsActive = true,
            //    IsDeleted = false,
            //});
            //roleRepository.Create(new RoleDTO
            //{
            //    Name = "User",
            //    Description = "کاربر",
            //    IsActive = true,
            //    IsDeleted = false,
            //});
            Roles = roleRepository.ReadAll().Data;
        }

        public void OnPostCreate()
        {
            var res = roleRepository.Create(RoleEntity);
            if (res.Success)
            {

            }
            else
            {
                ViewData["Errors"] = res.Messages;
            }
        }
    }
}
