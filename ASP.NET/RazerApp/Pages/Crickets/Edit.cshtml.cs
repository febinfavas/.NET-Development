using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazerApp.Data;
using RazerApp.Models;

namespace RazerApp.Pages.Crickets
{
    public class EditModel : PageModel
    {
        private readonly RazerApp.Data.RazerAppContext _context;

        public EditModel(RazerApp.Data.RazerAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cricket Cricket { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cricket = await _context.Cricket.FirstOrDefaultAsync(m => m.Id == id);

            if (Cricket == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cricket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CricketExists(Cricket.Id))
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

        private bool CricketExists(int id)
        {
            return _context.Cricket.Any(e => e.Id == id);
        }
    }
}
