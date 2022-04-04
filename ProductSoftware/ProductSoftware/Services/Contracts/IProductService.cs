using ShopOnline.Models.Dtos;

namespace ProductSoftware.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
        Task<ProductDto> GetItem(int id);

        Task<IEnumerable<ProductCategoryDto>> GetProductCategories();

    }
}
