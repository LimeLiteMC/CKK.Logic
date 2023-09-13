using CKK.Logic.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CKK.DB.Interfaces
{
    public interface IShoppingCartRepository
    {
        ShoppingCartItem AddToCart(int ShoppingCartId, int ProductId, int quantity);
        int ClearCart(int shoppingCartId);
        decimal GetTotal(int ShoppingCartId);
        List<ShoppingCartItem> GetProducts(int shoppingCartId);
        void Ordered(int shoppingCartId);

        Task Update(ShoppingCartItem entity);
        Task Add(ShoppingCartItem entity);
    }
}
