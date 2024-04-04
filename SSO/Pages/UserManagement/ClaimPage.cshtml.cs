using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Models;
using SSO.Repositpries;

namespace SSO.Pages.UserManagement
{
    public class ClaimPageModel : PageModel
    {
        private readonly IUserRepository userRepository;

        public ClaimPageModel(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public string Style { get; set; }
        public string Title { get; set; }
        [ModelBinder]
        public ClaimUser Entity { get; set; }

        public void OnGet()
        {
            Style = "d-none";
        }

        public void OnGetAddClaim()
        {
            Title = "ایجاد کلیم جدید";
            Style = "";
        }
        public IActionResult OnPostAddClaim()
        {
            Title = "ایجاد کلیم جدید";
            Entity.User = User.Identity.Name;
            var result = userRepository.AddClaim(Entity);
            if (result.Success)
            {
                Style = "d-none";
                return Page();
            }
            return Page();
        }
        public IActionResult OnGetCloseModal()
        {
            Style = "d-none";
            return Page();
        }


        #region Remove

        public void OnGetRemove()
        {

        }
        public void OnPostRemove()
        {

        }
        #endregion
        #region Update
        public void OnGetUpdate()
        {

        }
        public void OnPostUpdate()
        {

        }


        #endregion
        #region Read
        public void OnGetRead()
        {

        }
        public void OnPostRead()
        {

        }
        #endregion
    }
}
