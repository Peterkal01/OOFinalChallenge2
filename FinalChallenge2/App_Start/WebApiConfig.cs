using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace FinalChallenge2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
            name: "hkkh",
            routeTemplate: "api/Rooms/Used",
            defaults: new { controller = "UsedRoomsandClasses", action = "Get", id = RouteParameter.Optional }

            );

            config.Routes.MapHttpRoute(
                name: "dsgf",
                routeTemplate: "api/Rooms/Unused",
                defaults: new { controller = "UnusedRooms", action = "Get", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
            name: "sdff",
            routeTemplate: "api/Rooms/Computers",
            defaults: new { controller = "ComupterInClass", action = "Get", id = RouteParameter.Optional }
            );


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


        }
    }
}
