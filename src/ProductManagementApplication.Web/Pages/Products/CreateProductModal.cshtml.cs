using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductManagementApplication.Products;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementApplication.Web.Pages.Products
{
    public class CreateProductModalModel : ProductManagementApplicationPageModel
    {
        [BindProperty]
        public CreateEditProductViewModel Product { get; set; }

        public SelectListItem[] Categories { get; set; }
        private readonly IProductAppService _productAppService;

        public CreateProductModalModel(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }
        public async Task OnGetAsync()
        {
            Product = new CreateEditProductViewModel
            {
                ReleaseDate = DateTime.Now,
                StockState = ProductStockState.PreOrder
            };

            var categoryLookup =
            await _productAppService.GetCategoriesAsync();
            Categories = categoryLookup.Items
            .Select(x => new SelectListItem(x.Name,
           x.Id.ToString()))
            .ToArray();

        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _productAppService.CreateAsync(ObjectMapper.Map<CreateEditProductViewModel, CreateUpdateProductDto>(Product));

            return NoContent();

        }
    }
}
