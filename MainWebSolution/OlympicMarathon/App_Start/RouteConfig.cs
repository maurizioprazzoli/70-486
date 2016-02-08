using OlympicMarathon.Infrastructure.RouteConstraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OlympicMarathon
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                    name: "EditLog",
                    url: "RunLog/EditLog/{id}",
                    defaults: new
                            {
                                controller = "RunLog",
                                action = "EditLog",
                            },
                    constraints: new
                            {
                                id = @"\d+"
                            }
                    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "RunLog", action = "GetLog", id = UrlParameter.Optional },
                constraints: new { controller = new NotEqual("RunLog1"), action = new NotEqual("EditLog1") }
            );
        }
    }
}
