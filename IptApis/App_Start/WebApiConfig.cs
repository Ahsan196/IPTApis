﻿using System;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace IptApis
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.EnableCors();
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "ActionApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "PointApi",
                routeTemplate: "api/PointApp/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
