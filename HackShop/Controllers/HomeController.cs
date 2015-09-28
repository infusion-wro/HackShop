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
            ViewBag.Message = "Buy some vodka.";

            //return View(new Purchase(){VodkaPrice = 70.0});
            return View(new Purchase() { VodkaPrice = 70.0 });
        }


        [HttpPost]
        public ActionResult Shop(Purchase purchase)
        {
            if (ModelState.IsValid == false)
            {
                return View(purchase);
            }
            return Json(string.Format("You bought {0} vodkas for {1} ", purchase.VodkaCount, purchase.VodkaCount * purchase.VodkaPrice));
        }

    }
}