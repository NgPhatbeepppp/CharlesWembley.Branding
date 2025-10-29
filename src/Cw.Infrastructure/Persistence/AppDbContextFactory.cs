using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Cw.Infrastructure.Persistence
{
    
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            // Ưu tiên ENV: ConnectionStrings__Default (dễ dùng trên CI/local)
            var cs = Environment.GetEnvironmentVariable("ConnectionStrings__Default")
                     ?? "Server=localhost;Database=CwBranding;Trusted_Connection=True;TrustServerCertificate=True";

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(cs, b => b.MigrationsHistoryTable("__EFMigrationsHistory", "cms"))
                .Options;

            return new AppDbContext(options);
        }
    }
}
