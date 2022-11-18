using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Interfaces
{
    public abstract class InventoryItem
    {
        private Product Prod
        {
            get;
            set;   
        }
        private int Quantity
        {
            get;
            set; 
        }
        public Product GetProd()
        {
            return Prod;
        }
        public void SetProd(Product prod)
        {
            Prod = prod;
        }
        public int GetQuant()
        {
            return Quantity;
        }
        public void SetQuant(int quantity)
        {
            if (quantity < 0)
            {
                throw new InventoryItemStockTooLowException("The stock cannot fall below 0 items.");
            }
            Quantity = quantity;
        }

    }
}
