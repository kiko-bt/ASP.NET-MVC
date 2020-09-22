﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.Models.Domain
{
    public class Order
    {
        public int ID { get; set; }
        public Pizza Pizza { get; set; }
        public double Price { get; set; }
        public User User { get; set; }
        public bool Delivered { get; set; }
    }
}
