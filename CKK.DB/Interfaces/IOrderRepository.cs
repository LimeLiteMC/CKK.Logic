using System;
using System.Collections.Generic;
using CKK.DB.Interfaces;

namespace CKK.DB.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Order GetOrderByCustomerId(int id);
    }
}
