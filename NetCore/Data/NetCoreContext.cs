using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCore.Movies;

namespace NetCore.Models
{
    public class NetCoreContext : DbContext
    {
        public NetCoreContext (DbContextOptions<NetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<NetCore.Movies.Movie> Movie { get; set; }
    }
}
