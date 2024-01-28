using ProductManagementApplication.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ProductManagementApplication.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ProductManagementApplicationPageModel : AbpPageModel
{
    protected ProductManagementApplicationPageModel()
    {
        LocalizationResourceType = typeof(ProductManagementApplicationResource);
    }
}
