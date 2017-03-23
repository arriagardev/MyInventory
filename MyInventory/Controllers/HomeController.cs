using MyInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyInventory.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new Product()
            {
                Name = "Upbeat",
                RetailCost = 180
            };       

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}