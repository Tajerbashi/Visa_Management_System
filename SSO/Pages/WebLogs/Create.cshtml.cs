using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Pages.WebLogs
{
    public class CreateModel : PageModel
    {
        private readonly IBlogRepository _blogRepository;

        public CreateModel(IBlogRepository blogRepository)
        {
            var res = User;
            _blogRepository = blogRepository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BlogDTO BlogDTO { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            BlogDTO.CurrentUser = User;
            _blogRepository.Create(BlogDTO);

            return RedirectToPage("./Index");
        }
    }
}
