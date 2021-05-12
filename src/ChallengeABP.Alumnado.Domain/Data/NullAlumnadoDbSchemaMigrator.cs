using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ChallengeABP.Alumnado.Data
{
    /* This is used if database provider does't define
     * IAlumnadoDbSchemaMigrator implementation.
     */
    public class NullAlumnadoDbSchemaMigrator : IAlumnadoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}