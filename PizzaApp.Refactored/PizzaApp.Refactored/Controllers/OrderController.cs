﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.DataAccess;
using PizzaApp.Domain.Models;
using PizzaApp.Refactored.Models;
using PizzaApp.Services.Services;

namespace PizzaApp.Refactored.Controllers
{
    public class OrderController : Controller
    {
        private IPizzaOrderService _pizzaOrderService;
        private IUserService _userService;
        public OrderController()
        {
            _pizzaOrderService = new PizzaOrderService();
            _userService = new UserService();
        }

        [Route("Orders")]
        public IActionResult Index()
        {
            List<Order> orders = _pizzaOrderService.GetAllOrders();

            //MAPPING SECTION

            List<OrderItemViewModel> viewOrders = new List<OrderItemViewModel>();

            foreach (var order in orders)
            {
                List<PizzaViewModel> pizzasView = new List<PizzaViewModel>();
                foreach (var pizzaOrder in order.PizzaOrders)
                {
                    pizzasView.Add(new PizzaViewModel()
                    {
                        Id = pizzaOrder.Pizza.Id,
                        Image = pizzaOrder.Pizza.Image,
                        Name = pizzaOrder.Pizza.Name,
                        Price = pizzaOrder.Pizza.Price,
                        Size = pizzaOrder.Pizza.PizzaSize
                    });
                }

                viewOrders.Add(new OrderItemViewModel()
                {
                    Id = order.Id,
                    Firstname = order.User.FirstName,
                    Lastname = order.User.LastName,
                    Price = order.Price,
                    Pizzas = pizzasView
                });
            }

            OrdersViewModel model = new OrdersViewModel()
            {
                LastPizza = _pizzaOrderService.GetLastOrder().PizzaOrders.FirstOrDefault().Pizza.Name,
                MostPopularPizza = _pizzaOrderService.GetMostPopularPizza(),
                NameOfFirstCustomer = _userService.GetLastUserName(),
                OrderCount = _pizzaOrderService.GetOrderCount(),
                Orders = viewOrders
            };

            return View(model);
        }


        [HttpGet]
        public IActionResult Order(int pizzas)
        {
            OrderViewModel viewModel = new OrderViewModel();
            viewModel.Pizzas = new List<PizzaViewModel>();

            for (int i = 0; i < pizzas; i++)
            {
                viewModel.Pizzas.Add(new PizzaViewModel());
            }


            return View(viewModel);
        }


        [HttpPost]
        public IActionResult Order(OrderViewModel model)
        {
            Order order = new Order();
            List<PizzaOrder> pizzas = new List<PizzaOrder>();

            foreach (var pizzaViewModel in model.Pizzas)
            {
                PizzaOrder pizzaOrder = new PizzaOrder()
                {
                    Pizza = _pizzaOrderService.GetPizzaFromMenu(pizzaViewModel.Name, pizzaViewModel.Size),
                    Order = order
                };

                pizzaOrder.PizzaId = pizzaOrder.Pizza.Id;
                pizzas.Add(pizzaOrder);
            }

            User user = new User()
            {
                Address = model.Address,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Phone = model.Phone
            };

            order.PizzaOrders = pizzas;
            order.User = user;
            _pizzaOrderService.MakeNewOrder(order);

            return View("_ThankYou");
        }

        [HttpGet]
        public IActionResult Feedback(int reviews)
        {
            List<Feedback> feedbacks = _userService.GetFeedbacks(reviews);

            FeedbackViewModel feedbackViewModel = new FeedbackViewModel();


            foreach (var item in feedbacks)
            {
                item.Id = feedbackViewModel.Id;
                item.FullName = feedbackViewModel.Name;
                item.Comment = feedbackViewModel.Message;
                item.Email = feedbackViewModel.Email;
            }

            return View(feedbackViewModel);
        }


        //[HttpPost]
        //public IActionResult Feedback(Feedback entity) 
        //{
  
        //}


        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
