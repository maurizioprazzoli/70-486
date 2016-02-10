﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Various
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*xxx}");

            routes.MapRoute(
                name: "Bagels",
                url: "Bagel/GetBagel/{bagelName}",
                defaults: new { controller = "Bagel", action = "GetBagel" });

            routes.IgnoreRoute("Bagel/{*pathinfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}
