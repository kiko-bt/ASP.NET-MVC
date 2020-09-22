using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.Refactored.Models
{
    public class OrderItemViewModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double Price { get; set; }
        public List<PizzaViewModel> Pizzas { get; set; } = new List<PizzaViewModel>();
    }
}
