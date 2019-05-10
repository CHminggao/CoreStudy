using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorEFCore.Models;

namespace RazorEFCore.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly RazorEFCore.Models.SchoolStuContext _context;

        public IndexModel(RazorEFCore.Models.SchoolStuContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
