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

            

            return RedirectToPage("./Index");
        }
    }
}
