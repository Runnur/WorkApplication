﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WorkApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null, "", new { controller = "Home", action = "List", category = (string)null, page = 1 });

            routes.MapRoute(
                name: null,
                url: "Page{page}",
                defaults: new { controller = "Home", action = "List", category = (string)null },
                constraints: new { page = @"\d+" }
            );

            routes.MapRoute(null, "{category}", new { controller = "Home", action = "List", page = 1 }
            );

            routes.MapRoute(
                name: null,
                url: "{category}/Page{page}",
                defaults: new { controller = "Home", action = "List" },
                constraints: new { page = @"\d+" }
            );            

            routes.MapRoute(null, "{controller}/{action}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
