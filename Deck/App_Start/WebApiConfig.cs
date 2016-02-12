// *************************************************
// Deck.WebApiConfig.cs
// Last Modified: 02/12/2016 12:29 PM
// Modified By: Green, Brett (greenb1)
// *************************************************

namespace Deck
{
    using System.Reflection;
    using System.Web.Http;
    using Autofac;
    using Autofac.Integration.WebApi;
    using Microsoft.Owin.Security.OAuth;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute
                (
                    name: "DefaultApi",
                    routeTemplate: "{controller}/{action}/{id}",
                    defaults: new {id = RouteParameter.Optional}
                );

            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            builder.RegisterWebApiFilterProvider(config);
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}