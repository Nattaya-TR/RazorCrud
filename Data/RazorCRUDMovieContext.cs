using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCrudClasses;

namespace RazorCrudContext
{

    public class RazorCRUDMovieContext : DbContext
    {
        public RazorCRUDMovieContext (DbContextOptions<RazorCRUDMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorCrudClasses.Movie> Movie { get; set; }
    }
}