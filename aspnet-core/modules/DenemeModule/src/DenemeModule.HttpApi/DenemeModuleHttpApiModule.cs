using Localization.Resources.AbpUi;
using DenemeModule.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace DenemeModule;

[DependsOn(
    typeof(DenemeModuleApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class DenemeModuleHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(DenemeModuleHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<DenemeModuleResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
