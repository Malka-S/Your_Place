using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API
{
    public static class WebApiConfig 
    {
        public static void Register(HttpConfiguration config)
        {

            var cors = new EnableCorsAttribute("http://localhost:44390", "*", "*");
            config.EnableCors(cors);
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            {//// Web API configuration and services
             //var cors = new EnableCorsAttribute("https://localhost:44390", "*", "*");
             //config.EnableCors(cors);

                //// Web API routes
                //config.MapHttpAttributeRoutes();

                //config.Routes.MapHttpRoute(
                //    name: "DefaultApi",
                //    routeTemplate: "api/{controller}/{id}",
            } //    defaults: new { id = RouteParameter.Optional }

        }
    }
}
