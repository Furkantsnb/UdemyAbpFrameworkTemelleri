using DenemeApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace DenemeApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DenemeAppEntityFrameworkCoreModule),
    typeof(DenemeAppApplicationContractsModule)
    )]
public class DenemeAppDbMigratorModule : AbpModule
{
}
