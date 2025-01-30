using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieDbRazor.Model;

namespace MovieDbRazor.Data
{
    public class MovieDbRazorContext : DbContext
    {
        public MovieDbRazorContext (DbContextOptions<MovieDbRazorContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
