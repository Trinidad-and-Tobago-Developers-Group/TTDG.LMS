#nullable disable

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TTDG.LMS.DataContext.Migrations
{
    public class LMSDbContextFactory : IDesignTimeDbContextFactory<LMSDbContext>
    {
        public LMSDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LMSDbContext>();
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionStrings:Database"),
            sqlServerOptions => sqlServerOptions.MigrationsAssembly("TTDG.LMS.DataContext.Migrations"));

            return new LMSDbContext(optionsBuilder.Options);
        }
    }
}
