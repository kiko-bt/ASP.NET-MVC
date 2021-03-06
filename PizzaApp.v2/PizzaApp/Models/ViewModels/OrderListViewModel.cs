﻿using PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.Models.ViewModels
{
    public class OrderListViewModel
    {
        public string FirstPizza { get; set; }
        public int NumberOfOrders { get; set; }
        public string FirstCustomerName { get; set; }
        public List<Order> Orders { get; set; }
    }
}
