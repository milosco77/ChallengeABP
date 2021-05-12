using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ChallengeABP.Alumnado.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AlumnadoMigrationsDbContextFactory : IDesignTimeDbContextFactory<AlumnadoMigrationsDbContext>
    {
        public AlumnadoMigrationsDbContext CreateDbContext(string[] args)
        {
            AlumnadoEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AlumnadoMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new AlumnadoMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ChallengeABP.Alumnado.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
