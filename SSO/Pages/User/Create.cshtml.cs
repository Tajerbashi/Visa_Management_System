using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Domains;

namespace SSO.Pages.User
{
    public class CreateModel : PageModel
    {
        private readonly SSO.DatabaseApplication.DbContextApplication _context;

        public CreateModel(SSO.DatabaseApplication.DbContextApplication context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public UserEntity UserEntity { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Users.Add(UserEntity);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
