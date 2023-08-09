using System;

namespace CKK.DB.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        IOrderRepositoryOrders  Orders { get; }
        IShoppingCartRepository ShoppingCarts { get; }
    }
}
