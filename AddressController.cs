using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LaptopApplication.Models;
using System.ComponentModel.DataAnnotations;


namespace LaptopApplication.Controllers
{
    public class AddressController : Controller
    {
             
        public IActionResult Index()
        {

            return View();

        }

        public IActionResult OrderPlaced()
        {
            ViewBag.msg = "Your order has been placed and will be delivered shortly!";
            return View();
        }
    }
}
