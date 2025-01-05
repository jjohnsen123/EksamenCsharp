using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AsSimpleAsItGets.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public String Index()
        //{
        //    return "As simple as it gets";
        //}
        public ActionResult Index()
        {
            return View();
        }
    }
}