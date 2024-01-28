using Microsoft.AspNetCore.Builder;
using ProductManagementApplication;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<ProductManagementApplicationWebTestModule>();

public partial class Program
{
}
