using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DenemeApp;

[Dependency(ReplaceServices = true)]
public class DenemeAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DenemeApp";
}
