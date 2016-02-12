// *************************************************
// Deck.Global.asax.cs
// Last Modified: 02/12/2016 11:16 AM
// Modified By: Green, Brett (greenb1)
// *************************************************

namespace Deck
{
    using System.Web;
    using System.Web.Http;
    using System.Web.Mvc;

    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}