using ProductManagementApplication.Samples;
using Xunit;

namespace ProductManagementApplication.EntityFrameworkCore.Domains;

[Collection(ProductManagementApplicationTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ProductManagementApplicationEntityFrameworkCoreTestModule>
{

}
