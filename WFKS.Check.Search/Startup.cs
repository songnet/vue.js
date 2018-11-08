using Owin;
using System.Web.Http;
using WFKS.Check.Search.App_Start;

namespace WFKS.Check.Search
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            RouteConfig.Configure(config);
            FormatterConfig.Configure(config);
            SwaggerConfig.Configure(config);

            app.UseWebApi(config);
        }
    }
}
