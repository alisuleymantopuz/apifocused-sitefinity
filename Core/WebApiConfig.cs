﻿using System.Web.Http;

namespace SitefinityWebApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { action = "Index", id = RouteParameter.Optional }
            );

            config.Formatters.Add(new BrowserJsonFormatter());
        }
    }
}