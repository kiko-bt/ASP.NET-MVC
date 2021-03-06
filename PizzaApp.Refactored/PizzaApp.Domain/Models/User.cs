﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
        public List<Order> Orders { get; set; }
    }
}
