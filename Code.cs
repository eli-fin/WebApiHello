using System.Web.Http;

namespace WebApiHello
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config) =>
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}",
                defaults: new { id = RouteParameter.Optional }
            );
    }

    public class HelloController : ApiController
    {
        public string Get() => "Hello World";
    }
}
