using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DenemeApp.Data;
using Volo.Abp.DependencyInjection;

namespace DenemeApp.EntityFrameworkCore;

public class EntityFrameworkCoreDenemeAppDbSchemaMigrator
    : IDenemeAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDenemeAppDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the DenemeAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DenemeAppDbContext>()
            .Database
            .MigrateAsync();
    }
}
