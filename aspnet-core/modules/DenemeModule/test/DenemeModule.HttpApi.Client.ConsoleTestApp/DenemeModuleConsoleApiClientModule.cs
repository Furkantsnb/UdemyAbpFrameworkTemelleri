using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace DenemeModule;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DenemeModuleHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class DenemeModuleConsoleApiClientModule : AbpModule
{

}
