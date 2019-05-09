using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NetCore.Models;
using NetCore.Movies;

namespace NetCore.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly NetCore.Models.NetCoreContext _context;

        public IndexModel(NetCore.Models.NetCoreContext context)
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
