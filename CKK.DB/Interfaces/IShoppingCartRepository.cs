using System;
using System.Collections.Generic;

namespace CKK.DB.Interfaces
{
    public interface IShoppingCartRepository 
    {
        ShoppingCartItem AddToCart(int ShoppingCartId, int ProductId, int quantity);
        int ClearCart(int shoppingCartId);
        decimal GetTotal(int ShoppingCartId);
        List<ShoppingCartItem> GetProducts(int shoppingCartId);
        void Ordered(int shoppingCartId);
    }
}
