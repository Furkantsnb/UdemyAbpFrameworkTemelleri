using Volo.Abp.Modularity;

namespace DenemeApp;

[DependsOn(
    typeof(DenemeAppDomainModule),
    typeof(DenemeAppTestBaseModule)
)]
public class DenemeAppDomainTestModule : AbpModule
{

}
