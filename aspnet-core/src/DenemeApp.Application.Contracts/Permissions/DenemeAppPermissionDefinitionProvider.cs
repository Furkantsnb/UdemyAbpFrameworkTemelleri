using DenemeApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DenemeApp.Permissions;

public class DenemeAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DenemeAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DenemeAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DenemeAppResource>(name);
    }
}
