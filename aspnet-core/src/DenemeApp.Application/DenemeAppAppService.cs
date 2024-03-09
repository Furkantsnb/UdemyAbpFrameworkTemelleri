using System;
using System.Collections.Generic;
using System.Text;
using DenemeApp.Localization;
using Volo.Abp.Application.Services;

namespace DenemeApp;

/* Inherit your application services from this class.
 */
public abstract class DenemeAppAppService : ApplicationService
{
    protected DenemeAppAppService()
    {
        LocalizationResource = typeof(DenemeAppResource);
    }
}
