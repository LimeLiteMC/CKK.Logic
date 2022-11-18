using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    public class InventoryItemStockTooLowException :Exception
    {

        public int Quantity { get; }
        public InventoryItemStockTooLowException() { }
        public InventoryItemStockTooLowException(string message) : base(message) { }
        public InventoryItemStockTooLowException(string message, Exception inner) : base(message, inner)
        { }
        public InventoryItemStockTooLowException(string message, int quantity) : this(message)
        {
            Quantity = quantity;
        }
    }
}
