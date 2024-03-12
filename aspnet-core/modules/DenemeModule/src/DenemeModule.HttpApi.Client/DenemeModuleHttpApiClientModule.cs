using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace DenemeModule;

[DependsOn(
    typeof(DenemeModuleApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class DenemeModuleHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(DenemeModuleApplicationContractsModule).Assembly,
            DenemeModuleRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<DenemeModuleHttpApiClientModule>();
        });

    }
}
