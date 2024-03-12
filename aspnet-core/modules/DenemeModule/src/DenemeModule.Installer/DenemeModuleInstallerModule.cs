using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace DenemeModule;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class DenemeModuleInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<DenemeModuleInstallerModule>();
        });
    }
}
