using Volo.Abp.Modularity;

namespace ProductManagementApplication;

public abstract class ProductManagementApplicationApplicationTestBase<TStartupModule> : ProductManagementApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
