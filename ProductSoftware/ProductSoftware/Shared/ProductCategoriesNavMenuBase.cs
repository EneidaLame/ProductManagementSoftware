using Microsoft.AspNetCore.Components;
using ProductSoftware.Services.Contracts;
using ShopOnline.Models.Dtos;

namespace ProductSoftware.Shared
{
    public class ProductCategoriesNavMenuBase:ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductCategoryDto> ProductCategoryDtos { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                ProductCategoryDtos = await ProductService.GetProductCategories();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

    }
}
