using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Pages.Admin
{
    public class LoginModel : PageModel
    {
        private readonly IUserRepository userRepository;

        public LoginModel(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IActionResult OnGet()
        {
            //LoginDTO.ReturnUrl = "/";
            return Page();
        }

        [BindProperty]
        public LoginDTO LoginDTO { get; set; } = default!;

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
                return RedirectToPage(loginResult.Data.ReturnUrl);
            }
            if (loginResult.Results.RequiresTwoFactor)
            {
                //
            }
            if (loginResult.Results.IsLockedOut)
            {
                //
            }
            ModelState.AddModelError(string.Empty,"");

            return RedirectToPage("./Login");
        }

        public async Task<IActionResult> OnGetSignOut()
        {
            userRepository.SignOut();
            return RedirectToPage("Index");
        }

    }
}
