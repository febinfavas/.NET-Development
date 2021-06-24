using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazerApp.Data;
using RazerApp.Models;

namespace RazerApp.Pages.Crickets
{
    public class CreateModel : PageModel
    {
        private readonly RazerApp.Data.RazerAppContext _context;

        public CreateModel(RazerApp.Data.RazerAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cricket Cricket { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cricket.Add(Cricket);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}