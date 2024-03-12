using DenemeModule.Localization;
using Volo.Abp.Application.Services;

namespace DenemeModule;

public abstract class DenemeModuleAppService : ApplicationService
{
    protected DenemeModuleAppService()
    {
        LocalizationResource = typeof(DenemeModuleResource);
        ObjectMapperContext = typeof(DenemeModuleApplicationModule);
    }
}
