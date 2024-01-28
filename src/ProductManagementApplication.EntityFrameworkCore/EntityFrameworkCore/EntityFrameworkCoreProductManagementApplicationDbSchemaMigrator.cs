using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductManagementApplication.Data;
using Volo.Abp.DependencyInjection;

namespace ProductManagementApplication.EntityFrameworkCore;

public class EntityFrameworkCoreProductManagementApplicationDbSchemaMigrator
    : IProductManagementApplicationDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreProductManagementApplicationDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ProductManagementApplicationDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ProductManagementApplicationDbContext>()
            .Database
            .MigrateAsync();
    }
}
