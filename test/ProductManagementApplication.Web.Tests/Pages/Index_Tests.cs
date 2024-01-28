using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ProductManagementApplication.Pages;

public class Index_Tests : ProductManagementApplicationWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
