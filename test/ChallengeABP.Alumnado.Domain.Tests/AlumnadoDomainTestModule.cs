using ChallengeABP.Alumnado.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ChallengeABP.Alumnado
{
    [DependsOn(
        typeof(AlumnadoEntityFrameworkCoreTestModule)
        )]
    public class AlumnadoDomainTestModule : AbpModule
    {

    }
}