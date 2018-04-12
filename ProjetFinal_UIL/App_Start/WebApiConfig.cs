using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProjetFinal_UIL.UIL
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services API Web

            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{IdC}/{IdP}/{IdR}",
                defaults: new { IdC = RouteParameter.Optional, IdP = RouteParameter.Optional, IdR = RouteParameter.Optional }
            );
        }
    }
}
