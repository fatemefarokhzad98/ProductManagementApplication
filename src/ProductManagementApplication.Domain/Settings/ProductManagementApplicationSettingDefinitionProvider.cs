using Volo.Abp.Settings;

namespace ProductManagementApplication.Settings;

public class ProductManagementApplicationSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ProductManagementApplicationSettings.MySetting1));
    }
}
