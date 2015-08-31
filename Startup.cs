using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(ErrorMessage.Hub.Startup))]

namespace ErrorMessage.Hub
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}