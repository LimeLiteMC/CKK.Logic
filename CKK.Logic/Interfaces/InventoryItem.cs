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
        public Product Product { get; set; }
        private int quantity;
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (quantity < 0)
                {
                    throw new InventoryItemStockTooLowException("The stock cannot fall below 0 items.");
                }
                else
                {
                    quantity = Quantity;
                }
            }
        }

    }
}
