﻿using System;

namespace CKK.Logic.Models
{
    [Serializable]
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set;}
        public int ShoppingCartId {  get; set; }
    }
}
