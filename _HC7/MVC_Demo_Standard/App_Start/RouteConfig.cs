﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Demo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { area = "Highcharts", controller = "Demo", action = "Index", id = UrlParameter.Optional },
                namespaces: new string [] { "MVC_Demo.Areas.Highcharts.Controllers.Demo" }
            );

        }
    } 
}