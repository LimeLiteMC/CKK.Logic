using CKK.DB.Interfaces;
using CKK.Logic.Models;
using CKK.DB.UOW;
using CKK.DB;

namespace CKK.Online.Models
{
    public class ShopModel
    {
        public Order Order { get; set; }
        public IUnitOfWork UOW { get; set; }
        public ShopModel(IUnitOfWork work)
        {
            UOW = work;
            UOW.Orders.Add(Order);
        }
    }
}
