﻿using PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.Refactored.Models
{
    public class PizzaViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public PizzaSize Size { get; set; }
        public string Image { get; set; }
    }
}
