using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SSO.DatabaseApplication;
using SSO.Domains;

namespace SSO.Pages.User
{
    public class EditModel : PageModel
    {
        private readonly SSO.DatabaseApplication.DbContextApplication _context;

        public EditModel(SSO.DatabaseApplication.DbContextApplication context)
        {
            _context = context;
        }

        [BindProperty]
        public UserEntity UserEntity { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userentity =  await _context.Users.FirstOrDefaultAsync(m => m.Id == id);
            if (userentity == null)
            {
                return NotFound();
            }
            UserEntity = userentity;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(UserEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserEntityExists(UserEntity.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool UserEntityExists(long id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
