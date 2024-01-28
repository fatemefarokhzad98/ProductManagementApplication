using System.Threading.Tasks;

namespace ProductManagementApplication.Data;

public interface IProductManagementApplicationDbSchemaMigrator
{
    Task MigrateAsync();
}
