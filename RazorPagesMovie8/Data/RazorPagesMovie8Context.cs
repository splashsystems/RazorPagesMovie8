using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie8.Models;

namespace RazorPagesMovie8.Data
{
    public class RazorPagesMovie8Context : DbContext
    {
        public RazorPagesMovie8Context (DbContextOptions<RazorPagesMovie8Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie8.Models.Movie> Movie { get; set; }
    }
}
