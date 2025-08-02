using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JobTracker.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Job> Jobs { get; set; }
    }
}
