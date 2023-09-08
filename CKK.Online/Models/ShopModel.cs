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
            Order = new Order();
            Order.OrderId = 1;
            Order.OrderNumber = "1";
            Order.ShoppingCartId = 100;
            UOW = work;
            if (UOW.Orders.GetById(Order.OrderId).Result == null)
            {
                UOW.Orders.Add(Order);
            }
            else
            {
                UOW.Orders.Update(Order);
            }
        }
    }
}
