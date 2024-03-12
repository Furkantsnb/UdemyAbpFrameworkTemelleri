using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace DenemeModule;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(DenemeModuleDomainSharedModule)
)]
public class DenemeModuleDomainModule : AbpModule
{

}
