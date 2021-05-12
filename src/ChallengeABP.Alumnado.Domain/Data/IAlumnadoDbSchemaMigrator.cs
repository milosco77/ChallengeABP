using System.Threading.Tasks;

namespace ChallengeABP.Alumnado.Data
{
    public interface IAlumnadoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
