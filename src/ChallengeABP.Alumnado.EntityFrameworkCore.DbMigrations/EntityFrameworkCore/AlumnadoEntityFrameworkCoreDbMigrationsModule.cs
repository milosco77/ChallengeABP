using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace ChallengeABP.Alumnado.EntityFrameworkCore
{
    [DependsOn(
        typeof(AlumnadoEntityFrameworkCoreModule)
        )]
    public class AlumnadoEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AlumnadoMigrationsDbContext>();
        }
    }
}
