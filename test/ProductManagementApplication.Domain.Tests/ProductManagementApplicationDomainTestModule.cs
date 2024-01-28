using Volo.Abp.Modularity;

namespace ProductManagementApplication;

[DependsOn(
    typeof(ProductManagementApplicationDomainModule),
    typeof(ProductManagementApplicationTestBaseModule)
)]
public class ProductManagementApplicationDomainTestModule : AbpModule
{

}
