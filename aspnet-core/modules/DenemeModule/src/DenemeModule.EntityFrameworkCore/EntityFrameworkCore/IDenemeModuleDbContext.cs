using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace DenemeModule.EntityFrameworkCore;

[ConnectionStringName(DenemeModuleDbProperties.ConnectionStringName)]
public interface IDenemeModuleDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
