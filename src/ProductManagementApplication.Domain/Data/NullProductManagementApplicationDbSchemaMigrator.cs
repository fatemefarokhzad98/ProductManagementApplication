using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ProductManagementApplication.Data;

/* This is used if database provider does't define
 * IProductManagementApplicationDbSchemaMigrator implementation.
 */
public class NullProductManagementApplicationDbSchemaMigrator : IProductManagementApplicationDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
