using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Pages.UserManagement
{
    public class UserPageModel : PageModel
    {
        private readonly IUserRepository userRepository;
        private readonly IRoleRepository roleRepository;

        #region Property
        public string Title { get; set; }
        public string Style { get; set; }
        public List<UserDTO> Users { get; set; }
        #endregion

        [BindProperty]
        public long Id { get; set; }

        [BindProperty]
        [ModelBinder]
        public UserDTO UserDTO { get; set; }

        [ModelBinder]
        public List<SelectListItem> RolesModel { get; set; } = default!;


        public UserPageModel(IUserRepository userRepository, IRoleRepository roleRepository)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
        }
        public void OnGet()
        {
            Style = "d-none";
            LoadList();
        }
        public void OnGetRolesOfUser(long id)
        {
            LoadList();
            this.Id = id;
            var username = userRepository.Read(id).Data;
            Title = $"تعیین نقش برای کاربر {username.Name} {username.Family}";
            Style = "";
            RolesModel = roleRepository.AllRolesByExistRoleUser(id).Data.Select(c => new SelectListItem
            {
                //Selected = false,
                //Disabled = false,
                Text = c.Description,
                Value = c.Id.ToString(),
            }).ToList();
        }

        private void LoadList()
        {
            Users = new List<UserDTO>();
            var data = userRepository.ReadAll();
            Users = data.Data.ToList();
        }
        public void OnGetCloseModal()
        {
            Style = "d-none";
            LoadList();
        }

        public void OnPostSaveModal()
        {
            Style = "d-none";
            LoadList();
        }


        private void Fill(long id)
        {
            var user = userRepository.Read(id).Data;
            //Roles = roleRepository.AllRolesByExistRoleUser(id).Data.Select(model => new RoleOfUser
            //{
            //    Id = id,
            //    IsActive = true,
            //    IsDeleted = false,
            //    RoleDescription = model.Description,
            //    RoleName = model.Name,
            //    Selected = model.Selected,
            //    UserName = $"{user.Name} {user.Family}"
            //}).ToList();
        }

    }
}
