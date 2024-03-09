using System.Threading.Tasks;

namespace DenemeApp.Data;

public interface IDenemeAppDbSchemaMigrator
{
    Task MigrateAsync();
}
