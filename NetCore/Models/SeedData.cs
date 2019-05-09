using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace NetCore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new NetCoreContext(
                    serviceProvider.GetRequiredService<DbContextOptions<NetCoreContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(new Movies.Movie
                {
                    Title = "when Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Price = 7.99M,
                    Genre = "Romantic",
                    Rating = "R"
                },
                new Movies.Movie
                {
                    Title = "Ghostbusters",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "J"
                }
                );
                context.SaveChanges();
            }
        }
    }
}
