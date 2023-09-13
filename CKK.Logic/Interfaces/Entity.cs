using System;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Interfaces
{
    [Serializable]
    public abstract class Entity
    {
        private int id;
        private string name;
        public int Id
        {
            get
            {
                return id;
            }
            set 
            {
                if (value < 0)
                {
                    throw  new InvalidIdException("ID cannot be less than or equal to zero.", Id);
                }
                else
                {
                    id = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
