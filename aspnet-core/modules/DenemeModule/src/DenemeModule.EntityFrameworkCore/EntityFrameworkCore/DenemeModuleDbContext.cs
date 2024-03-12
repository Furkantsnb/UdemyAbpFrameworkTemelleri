using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace DenemeModule.EntityFrameworkCore;

[ConnectionStringName(DenemeModuleDbProperties.ConnectionStringName)]
public class DenemeModuleDbContext : AbpDbContext<DenemeModuleDbContext>, IDenemeModuleDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public DenemeModuleDbContext(DbContextOptions<DenemeModuleDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureDenemeModule();
    }
}
