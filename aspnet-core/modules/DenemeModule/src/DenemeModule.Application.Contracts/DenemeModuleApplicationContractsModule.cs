using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace DenemeModule;

[DependsOn(
    typeof(DenemeModuleDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class DenemeModuleApplicationContractsModule : AbpModule
{

}
