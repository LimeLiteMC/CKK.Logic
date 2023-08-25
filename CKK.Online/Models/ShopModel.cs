using CKK.DB.Interfaces;
using CKK.Logic.Models;
using CKK.DB.UOW;
using CKK.DB;

namespace CKK.Online.Models
{
    public class ShopModel
    {
        public Order Order { get; set; }
        public Order item1 { get; set; }
        public Order item2 { get; set; }
        public IUnitOfWork UOW { get; set; }
        public ShopModel(IUnitOfWork work)
        {
            if (Order == null || UOW.Orders.GetById(Order.OrderId) != Order)
            {
                Order = new Order();
                Order.OrderNumber = "1";
                Order.OrderId = 1;
                Order.ShoppingCartId = 100;
                item1 = new Order();
                item2 = new Order();
                item1.OrderNumber = "2";
                item1.OrderId = 2;
                item1.ShoppingCartId = 100;
                item2.OrderNumber = "3";
                item2.OrderId = 3;
                item2.ShoppingCartId = 100;
                UOW = work;
                UOW.Orders.Add(Order);
                UOW.Orders.Add(item1);
                UOW.Orders.Add(item2);
            }
            else
            {
                UOW = work;
                UOW.Orders.Add(Order);
            }
        }
    }
}
