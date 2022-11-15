using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem : InventoryItem
    {
        public ShoppingCartItem(Product product, int quantity)
        {
            prod = product;
            Quantity = quantity;
        }
        public override Product prod
        {
            get
            {
                return prod;
            }
            set
            {
                prod = value;
            }
        }
        public override int Quantity
        {
            get
            {
                return Quantity;
            }
            set
            {
                Quantity = value;
            }
        }
        public decimal GetTotal()
        {
            decimal total = prod.Price * Quantity;
            return total;
        }
    }
}
