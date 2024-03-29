using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Pages.Identity
{
    public class SignUpModel : PageModel
    {
        private readonly IUserRepository userRepository;

        public SignUpModel(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IActionResult OnGet()
        {

            return Page();

        }

        [BindProperty]
        public SignUpDTO SignUpDTO { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await Task.Delay(100);
            var entity = new UserDTO
            {
                Name = SignUpDTO.Name,
                Family = SignUpDTO.Family,
                Email = SignUpDTO.Email,
                UserName = SignUpDTO.UserName,
                Password = SignUpDTO.Password,
                IsDeleted = false,
                IsActive= true
            };
            var res = userRepository.Create(entity);
            if (res.Success)
            {
                return RedirectToPage("./Index");
            }
            ViewData["Messages"] = res.Messages;
            return Page();
        }
    }
}
