using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Pages.Identity
{
    public class LoginModel : PageModel
    {
        private readonly IUserRepository userRepository;

        public LoginModel(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [BindProperty]
        public LoginDTO LoginDTO { get; set; } = default!;
        public IActionResult OnGet()
        {
            ViewData["Ref"] = base.Request.Headers.Referer;
            return Page();
        }

        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var loginResult = userRepository.Login(LoginDTO);
            if (loginResult.Success)
            {
                if (loginResult.Results.RequiresTwoFactor)
                {
                    //
                }
                if (loginResult.Results.IsLockedOut)
                {
                    //
                }
                await Task.CompletedTask;
                ModelState.AddModelError(string.Empty, "");
                return Redirect($"/UserManagement/ProfilePage/{User.Identity.Name}");
                //return Redirect(loginResult.Data.ReturnUrl);
            }
            else
            {
                ViewData["Errors"] = loginResult.Messages;
                return Page();
            }
           
        }

        public async Task<IActionResult> OnGetSignOut()
        {
            userRepository.SignOut();
            await Task.CompletedTask;
            return RedirectToPage("Index");
        }

    }
}
