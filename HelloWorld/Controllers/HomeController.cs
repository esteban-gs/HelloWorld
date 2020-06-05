using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RsvpForm(Models.GuestResponse guestResponse)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View("Thanks", guestResponse);
        }

        public IActionResult Product()
        {
            //var myProduct = new Product
            //{
            //    ProductId = 1,
            //    Name = "Kayak",
            //    Description = "A boat for one person",
            //    Category = "water-sports",
            //    Price = 200m,
            //    ProductCount = 10
            //};

            var myProduct = productRepository.Products.First();
            return View(myProduct);
        }

        public IActionResult Products()
        {
            var products = new Product[]
            {
        new Product{ ProductId = 1, Name = "First One", Price = 1.11m, ProductCount = 0},
        new Product{ ProductId = 2, Name="Second One", Price = 2.22m, ProductCount = 1},
        new Product{ ProductId = 3, Name="Third One", Price = 3.33m, ProductCount = 435},
        new Product{ ProductId = 4, Name="Fourth One", Price = 4.44m, ProductCount = 234},
            };

            return View(products);
        }
    }
}