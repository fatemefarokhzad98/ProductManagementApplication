using ProductManagementApplication.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ProductManagementApplication.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProductManagementApplicationEntityFrameworkCoreModule),
    typeof(ProductManagementApplicationApplicationContractsModule)
    )]
public class ProductManagementApplicationDbMigratorModule : AbpModule
{
}
