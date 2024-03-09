using DenemeApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DenemeApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DenemeAppController : AbpControllerBase
{
    protected DenemeAppController()
    {
        LocalizationResource = typeof(DenemeAppResource);
    }
}
