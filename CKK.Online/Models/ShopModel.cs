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
            if (Order == null || UOW.Orders == Order)
            {
                Order = new Order();
                Order.OrderNumber = "1";
                Order.OrderId = 1;
                Order.ShoppingCartId = 100;
                UOW = work;
                UOW.Orders.Delete(Order.OrderId);
                UOW.Orders.Add(Order);
            }
            else
            {
                UOW = work;
                UOW.Orders.Add(Order);
            }
        }
    }
}
