using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic;
using CKK.Logic.Models;
using CKK.Logic.Interfaces;

namespace CKK.DB.Interfaces
{
    public interface IOrderRepository: IGenericRepository<Order>
    {
        Order GetOrderByCustomerID(int id);
    }
}
