using DenemeModule.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DenemeModule.Permissions;

public class DenemeModulePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DenemeModulePermissions.GroupName, L("Permission:DenemeModule"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DenemeModuleResource>(name);
    }
}
