using Volo.Abp.Reflection;

namespace DenemeModule.Permissions;

public class DenemeModulePermissions
{
    public const string GroupName = "DenemeModule";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(DenemeModulePermissions));
    }
}
