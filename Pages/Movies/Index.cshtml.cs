using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieDbRazor.Data;
using MovieDbRazor.Model;

namespace MovieDbRazor.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieDbRazor.Data.MovieDbRazorContext _context;

        public IndexModel(MovieDbRazor.Data.MovieDbRazorContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
