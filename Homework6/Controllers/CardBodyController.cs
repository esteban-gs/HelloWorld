using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Homework6.Controllers
{
    public class CardBodyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Generate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Generate(Models.CardBody cardBody)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return View("Confirm", cardBody);
        }
    }
}