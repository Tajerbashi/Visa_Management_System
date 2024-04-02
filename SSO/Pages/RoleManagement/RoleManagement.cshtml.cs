using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SSO.Pages.RoleManagement
{
    public class RoleManagementModel : PageModel
    {
        public long Id { get; set; }
        public string Mode { get; set; }

        public void OnGet(long id)
        {
            Id = id;
            Mode = "صفحه اولیه";
        }
        public void OnGetCreate(long id)
        {
            Id = id;
            Mode = "ایجاد کردن";
        }
        public void OnGetUpdate(long id)
        {
            Id = id;
            Mode = "ویرایش کردن";
        }
        public void OnGetDelete(long id)
        {
            Id = id;
            Mode = "حذف کردن";
        }
        public void OnGetRead(long id)
        {
            Id = id;
            Mode = "خواندن";
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
        }
        public void OnGetPrivilege(long id)
        {
            Id = id;
            Mode = "مدیریت دسترسی های این نقش";
        }
    }
}
