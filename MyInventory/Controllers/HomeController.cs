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

            ViewBag.Message = string.Format("{0}::{1} {2}",
                RouteData.Values[ "controller"],
                RouteData.Values["action"],
                RouteData.Values["id"]
                );

            var model = new ProductModels()
            {
                Name = "Free Spirit Sport",
                Cost = 350
            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Location = "Guadalajara, Jalisco, Mex.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}