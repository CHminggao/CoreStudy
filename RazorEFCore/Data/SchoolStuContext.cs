using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorEFCore.Models
{
    public class SchoolStuContext : DbContext
    {
        public SchoolStuContext (DbContextOptions<SchoolStuContext> options)
            : base(options)
        {
        }

        public DbSet<RazorEFCore.Models.Student> Student { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Course> Course { get; set; }
    }
}
