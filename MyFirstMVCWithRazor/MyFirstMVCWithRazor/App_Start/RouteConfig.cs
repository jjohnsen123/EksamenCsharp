using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyFirstMVCWithRazor
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{antal}",
                defaults: new { controller = "Home", action = "Index", antal = UrlParameter.Optional}
            );
            routes.MapRoute(
                name: "Main",
                url: "None/{action}/{antal}",
                defaults: new { controller = "Main", action = "Index", antal = UrlParameter.Optional }
            );
        }
    }
}
