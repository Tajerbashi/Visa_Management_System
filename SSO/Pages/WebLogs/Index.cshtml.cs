using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SSO.DatabaseApplication;
using SSO.Models.DTOs;
using SSO.Repositpries;

namespace SSO.Pages.WebLogs
{
    public class IndexModel : PageModel
    {
        private readonly IBlogRepository blogRepository;

        public IndexModel(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }

        public IList<BlogDTO> BlogDTO { get;set; } = default!;

        public async Task OnGetAsync()
        {
            BlogDTO = blogRepository.ReadAll().Data;
        }
    }
}
