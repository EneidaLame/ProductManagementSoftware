using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using ProductSoftware.Services.Contracts;
using ShopOnline.Models.Dtos;

namespace ProductSoftware.Pages
{
    public class ShoppingCartBase:ComponentBase
    {

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }

        public List<CartItemDto> ShoppingCartItems { get; set; }

        public string ErrorMessage { get; set; }
        protected string TotalPrice { get; set; }

       
        

        protected override async Task OnInitializedAsync()
        {
            try
            {
                ShoppingCartItems = await ShoppingCartService.GetItems(HardCoded.UserId);
                
            }
            catch (Exception ex)
            {

                ErrorMessage = ex.Message;
            }
        }
        protected async Task DeleteCartItem_Click(int id)
        {
            var cartItemDto = await ShoppingCartService.DeleteItem(id);
            RemoveCartItem(id);

        }
        private CartItemDto GetCartItem(int id)
        {
            return ShoppingCartItems.FirstOrDefault(i => i.Id == id);
        }
        private void RemoveCartItem(int id)
        {
            var cartItemDto = GetCartItem(id);
            ShoppingCartItems.Remove(cartItemDto);
        }
        public void CalculateTotalPrice(CartItemDto cartItemDto)
        {
            var item = GetCartItem(cartItemDto.Id);
            if(item != null)
            {
                item.TotalPrice = cartItemDto.Price + cartItemDto.Price;
            }
            else
            {
                cartItemDto.TotalPrice = 0;
            }
        }

        private void SetTotalPrice()
        {
            TotalPrice = this.ShoppingCartItems.Sum(p => p.TotalPrice).ToString("C");

        }


    }
}
