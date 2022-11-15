using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Product : Entity
    {
        public override int ID
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
        public override string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public decimal Price
        {
            get;
            set;
        }
    }
}
