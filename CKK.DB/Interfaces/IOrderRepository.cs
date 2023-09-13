using CKK.Logic.Models;

namespace CKK.DB.Interfaces
{
    public interface IOrderRepository: IGenericRepository<Order>
    {
        Order GetOrderByCustomerID(int id);
    }
}
