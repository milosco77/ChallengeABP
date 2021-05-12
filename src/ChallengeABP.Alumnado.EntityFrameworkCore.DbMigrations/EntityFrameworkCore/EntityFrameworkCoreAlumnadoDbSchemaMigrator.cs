using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ChallengeABP.Alumnado.Data;
using Volo.Abp.DependencyInjection;

namespace ChallengeABP.Alumnado.EntityFrameworkCore
{
    public class EntityFrameworkCoreAlumnadoDbSchemaMigrator
        : IAlumnadoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAlumnadoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AlumnadoMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AlumnadoMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}