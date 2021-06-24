using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazerApp.Data;
using RazerApp.Models;

namespace RazerApp.Pages.Crickets
{
    public class IndexModel : PageModel
    {
        private readonly RazerApp.Data.RazerAppContext _context;

        public IndexModel(RazerApp.Data.RazerAppContext context)
        {
            _context = context;
        }

        public IList<Cricket> Cricket { get;set; }

        [BindProperty(SupportsGet =true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var pos = from m in _context.Cricket
                          select m;

            if (!String.IsNullOrEmpty(SearchString))
            {
                pos = pos.Where(s => s.Position.Contains(SearchString));
            }

            Cricket = await pos.ToListAsync();
        }
    }
}
