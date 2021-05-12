using ChallengeABP.Alumnado.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ChallengeABP.Alumnado.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AlumnadoEntityFrameworkCoreDbMigrationsModule),
        typeof(AlumnadoApplicationContractsModule)
        )]
    public class AlumnadoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
