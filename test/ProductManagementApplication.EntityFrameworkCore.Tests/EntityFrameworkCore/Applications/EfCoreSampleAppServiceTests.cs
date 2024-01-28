using ProductManagementApplication.Samples;
using Xunit;

namespace ProductManagementApplication.EntityFrameworkCore.Applications;

[Collection(ProductManagementApplicationTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ProductManagementApplicationEntityFrameworkCoreTestModule>
{

}
