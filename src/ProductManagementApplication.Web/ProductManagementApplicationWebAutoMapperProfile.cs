using AutoMapper;
using ProductManagementApplication.Products;
using ProductManagementApplication.Web.Pages.Products;

namespace ProductManagementApplication.Web;

public class ProductManagementApplicationWebAutoMapperProfile : Profile
{
    public ProductManagementApplicationWebAutoMapperProfile()
    {
        CreateMap<ProductDto, CreateEditProductViewModel>();
        CreateMap<CreateEditProductViewModel, CreateUpdateProductDto>();

    }
        
}
