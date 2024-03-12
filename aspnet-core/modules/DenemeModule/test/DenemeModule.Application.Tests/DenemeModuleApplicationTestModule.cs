using Volo.Abp.Modularity;

namespace DenemeModule;

[DependsOn(
    typeof(DenemeModuleApplicationModule),
    typeof(DenemeModuleDomainTestModule)
    )]
public class DenemeModuleApplicationTestModule : AbpModule
{

}
