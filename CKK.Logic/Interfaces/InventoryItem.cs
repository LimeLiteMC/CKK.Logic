using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;

namespace CKK.Logic.Interfaces
{
    public abstract class InventoryItem
    {
        public Product prod
        {
            set;
            get;
        }
        public int Quantity
        {
            set;
            get;
        }
    }
}
