using AutoMapper;
using ProductManagementApplication.Categories;
using ProductManagementApplication.Products;


namespace ProductManagementApplication;

public class ProductManagementApplicationApplicationAutoMapperProfile : Profile
{
    public ProductManagementApplicationApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Product, ProductDto>();
        CreateMap<CreateUpdateProductDto, Product>();
        CreateMap<Category, CategoryLookupDto>();
        CreateMap<ProductDto, CreateEditProductViewModel>();



    }
}
