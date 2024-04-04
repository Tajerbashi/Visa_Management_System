using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Pages.RoleManagement
{
    public class RoleManagementModel : PageModel
    {
        public long Id { get; set; }
        public string Mode { get; set; }
        public string RoleName { get; set; }

        public List<UserOfRoleDTO> UsersOfRole { get; set; }
        public List<RoleOfUser> RoleOfUsers { get; set; }

        private readonly IUserRepository userRepository;
        private readonly IRoleRepository roleRepository;
        public RoleManagementModel(IUserRepository userRepository, IRoleRepository roleRepository)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
        }
        public void OnGet(long id)
        {
            Id = id;
            Mode = "صفحه اولیه";
        }
        public void OnGetAddRoleToUser(long id)
        {
            Id = id;
            Mode = "تعریف کاربر برای این نقش";
        }
        public void OnGetUsersOfRole(long id)
        {
            Id = id;
            Mode = "کاربران این نقش";
            RoleName = roleRepository.Read(id).Data.Name;
            UsersOfRole = roleRepository.UsersOfRole(RoleName).Data;
        }
        public void OnGetPrivilege(long id)
        {
            Id = id;
            Mode = "مدیریت دسترسی های این نقش";
        }
    }
}
