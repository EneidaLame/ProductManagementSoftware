using ProductSoftwareAPI.Entities;
using ShopOnline.Models.Dtos;

namespace ProductSoftwareAPI.Repositories.Contracts
{
    public interface IShoppingCartRepository
    {
        Task<CartItem> AddItem(CartItemToAddDto cartItemToAddDto);
        
        Task<CartItem> DeleteItem(int id);
        Task<CartItem> GetItem(int id);
        Task<IEnumerable<CartItem>> GetItems(int userId);
        
    }
}
