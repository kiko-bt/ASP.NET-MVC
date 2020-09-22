using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp
{
    public static class StaticDb
    {
        public static List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza()
            {
                Id = 1,
                Name = "Margarita",
                IsOnPromotion = false
            },
            new Pizza()
            {
                Id = 2,
                Name = "Bianca",
                IsOnPromotion = true
            },
            new Pizza()
            {
                Id = 3,
                Name = "Capri",
                IsOnPromotion = false
            }
        };

        public static List<Order> Orders = new List<Order>
        {
            new Order()
            {
                Id = 1,
                Name = "Margarita",
                Quantity = 6,
                Price = 200
            },
            new Order()
            {
                Id = 2,
                Name = "Capri",
                Quantity = 17,
                Price = 500
            },
            new Order()
            {
                Id = 3,
                Name = "Bianca",
                Quantity = 2,
                Price = 350
            },
        };
    }
}
