using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SSO.DatabaseApplication;
using SSO.Domains;

namespace SSO.Pages.User
{
    public class IndexModel : PageModel
    {
        private readonly SSO.DatabaseApplication.DbContextApplication _context;

        public IndexModel(SSO.DatabaseApplication.DbContextApplication context)
        {
            _context = context;
        }

        public IList<UserEntity> UserEntity { get;set; } = default!;

        public async Task OnGetAsync()
        {
            UserEntity = await _context.Users.ToListAsync();
        }
    }
}
