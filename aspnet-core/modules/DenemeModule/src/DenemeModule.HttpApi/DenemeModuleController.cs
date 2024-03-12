using DenemeModule.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DenemeModule;

public abstract class DenemeModuleController : AbpControllerBase
{
    protected DenemeModuleController()
    {
        LocalizationResource = typeof(DenemeModuleResource);
    }
}
