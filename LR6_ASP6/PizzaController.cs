using LR6_ASP6.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LR6_ASP6
{
    public class PizzaController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (user.Age > 16)
            {
                ViewBag.QuantityForm = true;
                ViewBag.User = user;
                return View("Order");
            }
            else
            {
                return View("SooYoung");
            }
        }

        [HttpPost]
        public IActionResult Order(List<Product> products)
        {
            ViewBag.Products = products;
            return View("OrderConfirmation");
        }
    }
}
