using Volo.Abp.Modularity;

namespace ProductManagementApplication;

/* Inherit from this class for your domain layer tests. */
public abstract class ProductManagementApplicationDomainTestBase<TStartupModule> : ProductManagementApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
