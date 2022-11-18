using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Interfaces
{
    public abstract class Entity
    {
        public int ID
        {
            get
            {
                return ID;
            }
            set 
            {
                if (ID <= 0)
                {
                    throw  new InvalidIdException("ID cannot be less than or equal to zero.", ID);
                }
            }
        }
        public string Name
        {
            get;
            set;
        }
    }
}
