using System;

namespace CKK.Logic.Exceptions
{
    [Serializable]
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
