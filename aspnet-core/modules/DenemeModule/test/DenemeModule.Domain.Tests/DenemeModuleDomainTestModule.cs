using Volo.Abp.Modularity;

namespace DenemeModule;

[DependsOn(
    typeof(DenemeModuleDomainModule),
    typeof(DenemeModuleTestBaseModule)
)]
public class DenemeModuleDomainTestModule : AbpModule
{

}
