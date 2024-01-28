using ProductManagementApplication.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ProductManagementApplication.Permissions;

public class ProductManagementApplicationPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProductManagementApplicationPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ProductManagementApplicationPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProductManagementApplicationResource>(name);
    }
}
