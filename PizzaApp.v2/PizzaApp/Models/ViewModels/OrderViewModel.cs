﻿using PizzaApp.Models.Domain;
using PizzaApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.Models.ViewModels
{
    public class OrderViewModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
        [Display(Name = "Pizza Name")]
        public string PizzaName { get; set; }
        public PizzaSize Size { get; set; }
        public double Price { get; set; }
        public bool Delievered { get; set; }
        public string Description { get; set; }
    }
}
