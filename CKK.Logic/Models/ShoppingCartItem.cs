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
            SetProd(product);
            SetQuant(quantity);
        }
        public decimal GetTotal()
        {
            decimal total = GetProd().Price * GetQuant();
            return total;
        }
    }
}
