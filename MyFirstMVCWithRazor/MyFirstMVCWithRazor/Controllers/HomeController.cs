using MyFirstMVCWithRazor.Models;
using MyFirstMVCWithRazor.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCWithRazor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? antal)
        {

            //ViewData["x"] = 7;
            //ViewBag.y = 8;
            //return View();
            return View("TypedView", new HomeModel(antal.HasValue?antal.Value:0));

        }

        public ActionResult GetPerson(String fornavn, String efternavn)
        {
            return View("PersonView",new Person(fornavn,efternavn));
        }


      [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            ViewBag.Antal = collection["Antal"];
            ViewBag.Varetype = collection["Varetype"];

            return View("KvitteringView");
        }

    }
}