using System;
using System.Collections.Generic;
using System.Text;
using ProductManagementApplication.Localization;
using Volo.Abp.Application.Services;

namespace ProductManagementApplication;

/* Inherit your application services from this class.
 */
public abstract class ProductManagementApplicationAppService : ApplicationService
{
    protected ProductManagementApplicationAppService()
    {
        LocalizationResource = typeof(ProductManagementApplicationResource);
    }
}
