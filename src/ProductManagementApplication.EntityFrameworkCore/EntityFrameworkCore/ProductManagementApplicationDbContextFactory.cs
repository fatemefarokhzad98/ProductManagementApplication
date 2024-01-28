using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ProductManagementApplication.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ProductManagementApplicationDbContextFactory : IDesignTimeDbContextFactory<ProductManagementApplicationDbContext>
{
    public ProductManagementApplicationDbContext CreateDbContext(string[] args)
    {
        ProductManagementApplicationEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ProductManagementApplicationDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ProductManagementApplicationDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ProductManagementApplication.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
