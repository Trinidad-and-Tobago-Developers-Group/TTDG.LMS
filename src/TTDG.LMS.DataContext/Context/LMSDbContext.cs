#nullable disable

using Microsoft.EntityFrameworkCore;

namespace TTDG.LMS.DataContext
{
    public class LMSDbContext : DbContext
    {
        public LMSDbContext(DbContextOptions<LMSDbContext> options) : base(options)
        {
        }

        public DbSet<Organization> Organizations { get; set; }
    }
}
