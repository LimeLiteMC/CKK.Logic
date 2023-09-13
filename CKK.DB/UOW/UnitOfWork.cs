using CKK.DB.Interfaces;
using CKK.DB.Repository;

namespace CKK.DB.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IConnectionFactory Conn)
        {
            Products = new ProductRepository(Conn);
            Orders = new OrderRepository(Conn);
            ShoppingCarts = new ShoppingCartRepository(Conn);
        }
        public IProductRepository Products { get; private set; }
        public IOrderRepository Orders { get; private set; }
        public IShoppingCartRepository ShoppingCarts { get; set; }
    }
}
