using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ProductManagementApplication.Web;

[Dependency(ReplaceServices = true)]
public class ProductManagementApplicationBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProductManagementApplication";
}
