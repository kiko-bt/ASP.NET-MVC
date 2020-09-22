using PizzaApp.Models.Domain;
using PizzaApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.DB
{
    public static class StaticDB
    {
        public static List<Order> Orders;
        public static List<Pizza> Menu;
        public static List<User> Users;
        public static int OrderID;
        public static int UserID;

        static StaticDB()
        {
            Users = new List<User>()
            {
                new User
                {
                    ID = 1,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Address = "Bob Street",
                    Phone = 070222333
                },
                new User
                {
                    ID = 2,
                    FirstName = "Jill",
                    LastName = "Wayne",
                    Address = "Jill Street",
                    Phone = 070222444
                }
            };

            Menu = new List<Pizza>()
            {
                new Pizza()
                {
                    ID = 1,
                    Name = "Kapri",
                    Price = 7,
                    Size = PizzaSize.Medium,
                    Description = "The name of this pizza literally translates to capricious, and seems quite appropriate, considering that the toppings tend to vary from one region to another. Capricciosa is made with an ever-changing combination of ingredients which most often include tomatoes, mozzarella, mushrooms, artichokes, ham, olives, and a sliced hard-boiled egg, whereas in central and northern Italy, it is not uncommon to add capers, sausages, and sometimes even anchovies."
                },
                new Pizza()
                {
                    ID = 2,
                    Name = "Kapri",
                    Price = 8,
                    Size = PizzaSize.Large,
                    Description = "The name of this pizza literally translates to capricious, and seems quite appropriate, considering that the toppings tend to vary from one region to another. Capricciosa is made with an ever-changing combination of ingredients which most often include tomatoes, mozzarella, mushrooms, artichokes, ham, olives, and a sliced hard-boiled egg, whereas in central and northern Italy, it is not uncommon to add capers, sausages, and sometimes even anchovies."
                },
                new Pizza()
                {
                    ID = 3,
                    Name = "Kapri",
                    Price = 9,
                    Size = PizzaSize.Family,
                    Description = "The name of this pizza literally translates to capricious, and seems quite appropriate, considering that the toppings tend to vary from one region to another. Capricciosa is made with an ever-changing combination of ingredients which most often include tomatoes, mozzarella, mushrooms, artichokes, ham, olives, and a sliced hard-boiled egg, whereas in central and northern Italy, it is not uncommon to add capers, sausages, and sometimes even anchovies."
                },
                new Pizza()
                {
                    ID = 4,
                    Name = "Peperoni",
                    Price = 9,
                    Size = PizzaSize.Medium,
                    Description = "Pepperoni is an American variety of salami, made from a cured mixture of pork and beef seasoned with paprika or other chili pepper."
                },
                new Pizza()
                {
                    ID = 5,
                    Name = "Peperoni",
                    Price = 10,
                    Size = PizzaSize.Large,
                    Description = "Pepperoni is an American variety of salami, made from a cured mixture of pork and beef seasoned with paprika or other chili pepper."
                },
                new Pizza()
                {
                    ID = 6,
                    Name = "Peperoni",
                    Price = 11,
                    Size = PizzaSize.Family,
                    Description = "Pepperoni is an American variety of salami, made from a cured mixture of pork and beef seasoned with paprika or other chili pepper."
                },
                new Pizza()
                {
                    ID = 7,
                    Name = "Margarita",
                    Price = 6,
                    Size = PizzaSize.Medium,
                    Description = "Margherita is a typical Neapolitan pizza, made with San Marzano tomatoes, mozzarella cheese, fresh basil, salt and extra-virgin olive oil. Traditionally, it is made with fior di latte (cow's milk mozzarella) rather than buffalo mozzarella."
                },
                new Pizza()
                {
                    ID = 8,
                    Name = "Margarita",
                    Price = 7,
                    Size = PizzaSize.Large,
                    Description = "Margherita is a typical Neapolitan pizza, made with San Marzano tomatoes, mozzarella cheese, fresh basil, salt and extra-virgin olive oil. Traditionally, it is made with fior di latte (cow's milk mozzarella) rather than buffalo mozzarella."
                },
                new Pizza()
                {
                    ID = 9,
                    Name = "Margarita",
                    Price = 8,
                    Size = PizzaSize.Family,
                    Description = "Margherita is a typical Neapolitan pizza, made with San Marzano tomatoes, mozzarella cheese, fresh basil, salt and extra-virgin olive oil. Traditionally, it is made with fior di latte (cow's milk mozzarella) rather than buffalo mozzarella."
                },
                new Pizza()
                {
                    ID = 10,
                    Name = "Siciliana",
                    Price = 6.5,
                    Size = PizzaSize.Medium,
                    Description = "Sicilian pizza is pizza prepared in a manner that originated in Sicily, Italy. Traditional Sicilian pizza is often thick crusted and rectangular, but can also be round and similar to the Neapolitan pizza. It is often topped with onions, anchovies, tomatoes, herbs and strong cheese such as caciocavallo and toma. Other versions do not include cheese."
                },
                new Pizza()
                {
                    ID = 11,
                    Name = "Siciliana",
                    Price = 9.5,
                    Size = PizzaSize.Large,
                    Description = "Sicilian pizza is pizza prepared in a manner that originated in Sicily, Italy. Traditional Sicilian pizza is often thick crusted and rectangular, but can also be round and similar to the Neapolitan pizza. It is often topped with onions, anchovies, tomatoes, herbs and strong cheese such as caciocavallo and toma. Other versions do not include cheese."
                },
                new Pizza()
                {
                    ID = 12,
                    Name = "Siciliana",
                    Price = 9.5,
                    Size = PizzaSize.Family,
                    Description = "Sicilian pizza is pizza prepared in a manner that originated in Sicily, Italy. Traditional Sicilian pizza is often thick crusted and rectangular, but can also be round and similar to the Neapolitan pizza. It is often topped with onions, anchovies, tomatoes, herbs and strong cheese such as caciocavallo and toma. Other versions do not include cheese."
                }
            };

            Orders = new List<Order>()
            {
                new Order()
                {
                    ID = 1,
                    User = Users[0],
                    Pizza = Menu[0],
                    Delivered = false,
                    Price = Menu[0].Price + 2
                },
                new Order()
                {
                    ID = 2,
                    User = Users[0],
                    Pizza = Menu[1],
                    Delivered = true,
                    Price = Menu[1].Price + 2
                },
                new Order()
                {
                    ID = 3,
                    User = Users[1],
                    Pizza = Menu[2],
                    Delivered = false,
                    Price = Menu[0].Price + 2
                },
            };
            OrderID = 3;
            UserID = 2;
        }
    }
}
