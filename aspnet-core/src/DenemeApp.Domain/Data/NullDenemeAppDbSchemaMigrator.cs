using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DenemeApp.Data;

/* This is used if database provider does't define
 * IDenemeAppDbSchemaMigrator implementation.
 */
public class NullDenemeAppDbSchemaMigrator : IDenemeAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
