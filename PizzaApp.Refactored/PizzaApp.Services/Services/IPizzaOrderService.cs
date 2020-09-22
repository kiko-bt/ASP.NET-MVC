using PizzaApp.Domain.Enums;
using PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.Services.Services
{
    public interface IPizzaOrderService
    {
        List<Order> GetAllOrders();
        Order GetOrderById(int id);
        List<Pizza> GetMenu();
        int GetOrderCount();
        string GetMostPopularPizza();
        Order GetLastOrder();
        Pizza GetPizzaFromMenu(string name, PizzaSize size);
        void MakeNewOrder(Order order);
    }
}
