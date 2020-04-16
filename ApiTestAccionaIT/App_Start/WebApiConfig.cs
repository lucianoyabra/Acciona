using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ApiTestAccionaIT
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();


            config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional});

            //OTRAS OPCIONES
            //config.Routes.MapHttpRoute(
            //name: "LoginApi",
            //routeTemplate: "api/{controller}/{action}/{user}/{pass}",
            //defaults: new { user = RouteParameter.Optional, pass = RouteParameter.Optional });
            
            //config.Routes.MapHttpRoute(
            //name: "ProvinciasApi",
            //routeTemplate: "api/{controller}/{action}/{provincia}",
            //defaults: new { provincia = RouteParameter.Optional});

        }
    }
}
