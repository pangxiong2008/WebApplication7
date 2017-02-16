using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication7
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{*catchall}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces:new[] { "URLsAndRoutes.AdditionalControllers", "UrlsAndRoutes.Controllers" }
            );

            routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
new { controller = "Home", action = "Index", id = UrlParameter.Optional },
new[] { "URLsAndRoutes.Controllers" });


        }
    }
}
