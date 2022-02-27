using Microsoft.AspNetCore.Components;
using ProductSoftware.Services;
using ProductSoftware.Services.Contracts;
using ShopOnline.Models.Dtos;

namespace ProductSoftware.Pages
{
    public class ProductsBase:ComponentBase
    {
        [Inject]
        public IProductService ProductsService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductsService.GetItems();
        }

        protected IOrderedEnumerable<IGrouping<int,ProductDto>> GetGroupedProductsByCategory()
		{
            return from product in Products
                   group product by product.CategoryId into prodByCatGroup
                   orderby prodByCatGroup.Key
                   select prodByCatGroup;
        }

        protected string GetCategoryName(IGrouping<int, ProductDto> groupedProductDto)
		{
            return groupedProductDto.FirstOrDefault(pg => pg.CategoryId == groupedProductDto.Key).CategoryName;
		}
    }
}
