using Volo.Abp.Settings;

namespace DenemeApp.Settings;

public class DenemeAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(DenemeAppSettings.MySetting1));
    }
}
