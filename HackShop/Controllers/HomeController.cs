using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HackShop.Models;

namespace HackShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Shop()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        [HttpPost]
        public ActionResult Shop(Purchase purchase)
        {
            return Json(string.Format("You bought {0} vodkas for {1} ", purchase.VodkaCount, purchase.VodkaCount * purchase.VodkaPrice));
        }

    }
}