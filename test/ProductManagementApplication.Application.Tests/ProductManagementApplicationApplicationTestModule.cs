using Volo.Abp.Modularity;

namespace ProductManagementApplication;

[DependsOn(
    typeof(ProductManagementApplicationApplicationModule),
    typeof(ProductManagementApplicationDomainTestModule)
)]
public class ProductManagementApplicationApplicationTestModule : AbpModule
{

}
