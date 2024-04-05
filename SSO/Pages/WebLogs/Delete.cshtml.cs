using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Pages.WebLogs
{
    public class DeleteModel : PageModel
    {
        private readonly IBlogRepository _blogRepository;

        public DeleteModel(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        [BindProperty]
        public BlogDTO BlogDTO { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogdto = _blogRepository.Read(id.Value).Data;

            if (blogdto == null)
            {
                return NotFound();
            }
            else
            {
                BlogDTO = blogdto;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogdto = _blogRepository.Read(id.Value).Data;
            if (blogdto != null)
            {
                BlogDTO = blogdto;
                _blogRepository.Delete(BlogDTO);
            }

            return RedirectToPage("./Index");
        }
    }
}
