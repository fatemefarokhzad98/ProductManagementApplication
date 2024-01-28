using ProductManagementApplication.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductManagementApplication.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProductManagementApplicationController : AbpControllerBase
{
    protected ProductManagementApplicationController()
    {
        LocalizationResource = typeof(ProductManagementApplicationResource);
    }
}
