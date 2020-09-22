using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.DB;
using PizzaApp.Models.Domain;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("Orders")]
        public IActionResult Index()
        {
            Order firstOrder = StaticDB.Orders.FirstOrDefault();
            OrderListViewModel ordersViewModel = new OrderListViewModel()
            {
                FirstPizza = firstOrder.Pizza.Name,
                NumberOfOrders = StaticDB.Orders.Count,
                FirstCustomerName = $"{firstOrder.User.FirstName} {firstOrder.User.LastName}",
                Orders = StaticDB.Orders
            };
            return View(ordersViewModel);
        }

        public IActionResult Details(int? id)
        {
            Order order = StaticDB.Orders.FirstOrDefault(x => x.ID == id);
            OrderViewModel viewModel = new OrderViewModel()
            {
                FirstName = order.User.FirstName,
                LastName = order.User.LastName,
                Address = order.User.Address,
                Phone = order.User.Phone,
                PizzaName = order.Pizza.Name,
                Size = order.Pizza.Size,
                Price = order.Price,
                Delievered = order.Delivered,
                Description = order.Pizza.Description
            };

            return View(viewModel);
        }

        public IActionResult Create(string error)
        {
            ViewBag.Error = error == null ? "" : error;
            OrderViewModel model = new OrderViewModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(OrderViewModel model)
        {
            //First check if there is a pizza like the user entered in the form - by size and name
            Pizza pizza = StaticDB.Menu.FirstOrDefault(x => x.Name == model.PizzaName && x.Size == model.Size);

            //If there is no such pizza in the database, return an error message to the user
            if (pizza == null)
                return RedirectToAction("Create", new { error = "There is no such pizza in the menu!" });


            StaticDB.UserID++;
            User user = new User()
            {
                ID = StaticDB.UserID,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                Phone = model.Phone
            };
            StaticDB.OrderID++;
            Order order = new Order()
            {
                ID = StaticDB.OrderID,
                Delivered = true,
                Pizza = pizza,
                Price = pizza.Price + 2,
                User = user
            };


            StaticDB.Users.Add(user);
            StaticDB.Orders.Add(order);

            return View("_ThankYou");
        }
    }
}
