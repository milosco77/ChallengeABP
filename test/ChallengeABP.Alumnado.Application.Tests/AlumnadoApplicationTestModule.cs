using Volo.Abp.Modularity;

namespace ChallengeABP.Alumnado
{
    [DependsOn(
        typeof(AlumnadoApplicationModule),
        typeof(AlumnadoDomainTestModule)
        )]
    public class AlumnadoApplicationTestModule : AbpModule
    {

    }
}