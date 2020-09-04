using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("Orders")]
        public IActionResult Orders()
        {
            ViewData["Message"] = "Direction of a court or judge normally made or entered in writing, and not included in a judgment, which determines some point or directs some step in the proceedings. The decision of a court or judge is made in the form of an order.";
            return View();
        }


        public IActionResult Details(int? id)
        {
            if (id == null)
                return new EmptyResult();
            else
                ViewData["Message"] = "The process has not finished, we are close to finishing it but it's important that we finish defining the details before making a final decision.";
                return View();
        }


        public IActionResult JsonData()
        {
            Order order = new Order()
            {
                Id = 1,
                Quantity = 2,
                Price = 350
            };

            return new JsonResult(order);
        }

        public IActionResult GoHome()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult OrderDetails()
        {
            List<Order> orders = StaticDb.Orders;
            return View(orders);
        }
    }
}
