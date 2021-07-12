using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TP_DesignPatter
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Index",
                url: "{controller}/{action}",
                defaults: new { controller = "Compte", action = "Index" }
            );

            routes.MapRoute(
                name: "Create",
                url: "{controller}/{action}",
                defaults: new { controller = "Compte", action = "Create" }
            );

            routes.MapRoute(
                name: "Edit",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Compte", action = "Edit" }
            );

            routes.MapRoute(
                name: "Delete",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Compte", action = "Delete" }
            );
        }
    }
}
