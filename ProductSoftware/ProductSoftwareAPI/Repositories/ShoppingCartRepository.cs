 using Microsoft.EntityFrameworkCore;
using ProductSoftwareAPI.Data;
using ProductSoftwareAPI.Entities;
using ProductSoftwareAPI.Repositories.Contracts;
using ShopOnline.Models.Dtos;

namespace ProductSoftwareAPI.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly ProductSoftwareDbContext productSoftwareDbContext;

        public ShoppingCartRepository(ProductSoftwareDbContext productSoftwareDbContext)
        {
            this.productSoftwareDbContext = productSoftwareDbContext;
        }

        private async Task<bool> CartItemExists(int cartId, int productId)
        {
            return await this.productSoftwareDbContext.CartItems.AnyAsync(c => c.CartId == cartId && 
                                                                          c.ProductId == productId);

        }
        public async Task<CartItem> AddItem(CartItemToAddDto cartItemToAddDto)
        {
            if (await CartItemExists(cartItemToAddDto.CartId, cartItemToAddDto.ProductId) == false)
            {
                var item = await (from product in this.productSoftwareDbContext.Products
                                  where product.Id == cartItemToAddDto.ProductId
                                  select new CartItem
                                  {
                                      CartId = cartItemToAddDto.CartId,
                                      ProductId = cartItemToAddDto.ProductId,
                                      Qty = cartItemToAddDto.Qty
                                  }).SingleOrDefaultAsync();
                if (item != null)
                {
                    var result = await this.productSoftwareDbContext.CartItems.AddAsync(item);
                    await this.productSoftwareDbContext.SaveChangesAsync();
                    return result.Entity;
                }
            }
            return null;
        }

        public async Task<CartItem> DeleteItem(int id)
        {
            var item = await this.productSoftwareDbContext.CartItems.FindAsync(id);

            if (item != null)
            {
                this.productSoftwareDbContext.CartItems.Remove(item);
                await this.productSoftwareDbContext.SaveChangesAsync();
            }
            return item;
        }

        public async Task<CartItem> GetItem(int id)
        {
            return await (from cart in this.productSoftwareDbContext.Carts
                          join cartItem in this.productSoftwareDbContext.CartItems on cart.Id equals cartItem.CartId
                          where cartItem.Id == id
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<CartItem>> GetItems(int userId)
        {
            return await (from cart in this.productSoftwareDbContext.Carts
                          join cartItem in this.productSoftwareDbContext.CartItems on cart.Id equals cartItem.CartId
                          where cart.UserId == userId
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).ToListAsync();
        }
        public async Task<CartItem> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto)
        {
            var item = await this.productSoftwareDbContext.CartItems.FindAsync(id);

            if (item != null)
            {
                item.Qty = cartItemQtyUpdateDto.Qty;
                await this.productSoftwareDbContext.SaveChangesAsync();
                return item;
            }

            return null;
        }


    }
}
