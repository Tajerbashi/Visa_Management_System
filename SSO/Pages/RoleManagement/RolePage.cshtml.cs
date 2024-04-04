using Humanizer;
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
            LoadPage();
        }


        #region Create
        public void OnGetCreate()
        {
            Style = "";
            Title = "ایجاد نقش جدید";
            Role = new RoleDTO();
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
        #endregion


        #region Update
        public void OnGetUpdate(long id)
        {
            Style = "";
            Title = "ویرایش نقش";
            Role = roleRepository.Read(id).Data;
            LoadPage();
        }
        public void OnPostUpdate()
        {
            var res = roleRepository.Update(Role);
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
        #endregion
        #region Read
        public void OnGetRead(long id)
        {
            Style = "";
            Title = "نمایش اطلاعات نقش";
            Role = roleRepository.Read(id).Data;
            LoadPage();
        }
        #endregion
        #region Delete
        public void OnGetDelete(long id)
        {
            Style = "";
            Title = "حذف نقش";
            LoadPage();
        }
        public void OnPostDelete()
        {
            var res = roleRepository.Delete(Role.Id);
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
        #endregion

        public void OnGetCloseModal()
        {
            Style = "d-none";
            LoadPage();
        }

        private void LoadPage()
        {
            Roles = roleRepository.ReadAll().Data;
        }
    }
}
