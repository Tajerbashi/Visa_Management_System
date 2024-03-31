using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SSO.Pages.Admin
{
    public class UserManagementModel : PageModel
    {
        public long Id { get; set; }
        public string Mode { get; set; }
        //public void OnGet(string id)
        //{
        //    Id = id;
        //}

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
    }
}
