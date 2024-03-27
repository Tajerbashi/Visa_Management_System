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
    public class DetailsModel : PageModel
    {
        private readonly SSO.DatabaseApplication.DbContextApplication _context;

        public DetailsModel(SSO.DatabaseApplication.DbContextApplication context)
        {
            _context = context;
        }

        public UserEntity UserEntity { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userentity = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);
            if (userentity == null)
            {
                return NotFound();
            }
            else
            {
                UserEntity = userentity;
            }
            return Page();
        }
    }
}
