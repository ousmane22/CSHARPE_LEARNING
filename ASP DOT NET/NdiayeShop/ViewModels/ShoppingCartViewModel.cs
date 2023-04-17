using NdiayeShop.Models;

namespace NdiayeShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public IShoppingCart ShoppingCart { get;  }
        public decimal ShoppingCartTotal { get; set; }

        public ShoppingCartViewModel(IShoppingCart shoppingCart,decimal shoppingCartTotal)
        {
            ShoppingCart = shoppingCart;
            ShoppingCartTotal = shoppingCartTotal;
        }
    }
}
