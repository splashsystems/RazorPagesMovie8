using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie8.Data;
using RazorPagesMovie8.Models;

namespace RazorPagesMovie8.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie8.Data.RazorPagesMovie8Context _context;

        public IndexModel(RazorPagesMovie8.Data.RazorPagesMovie8Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
