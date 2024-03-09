using Volo.Abp.Modularity;

namespace DenemeApp;

[DependsOn(
    typeof(DenemeAppApplicationModule),
    typeof(DenemeAppDomainTestModule)
)]
public class DenemeAppApplicationTestModule : AbpModule
{

}
