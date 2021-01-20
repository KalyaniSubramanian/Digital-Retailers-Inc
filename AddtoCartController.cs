using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using LaptopApplication.Models;
using Microsoft.AspNetCore.Http;
namespace LaptopApplication.Controllers
{

    public class AddToCartController : Controller
    {

        private readonly LaptopDBContext _context;
        public AddToCartController(LaptopDBContext context)
        {
            _context = context;
        }
        public ActionResult Index(int id)
        {
            string user = HttpContext.Session.GetString("LoginUser");
            if (string.IsNullOrEmpty(user))
            {
                TempData["ItemID"] = id;
                return RedirectToAction("Login");
            }
            else
            {
                LaptopModel model = _context.Laptops.First(s => s.SNo == id);
                return View(model);
            }
        }

        public ActionResult Login()
        {
            ViewBag.ItemID = Convert.ToInt32(TempData["ItemID"]);

            return View();
        }

        [HttpPost]
        public ActionResult Login(string MailID, string ItemID)
        {
            HttpContext.Session.SetString("LoginUser", MailID);

            return RedirectToAction("PlaceOrder","PlaceOrder");
        }


    }
}
