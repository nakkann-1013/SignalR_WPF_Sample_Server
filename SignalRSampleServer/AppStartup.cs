using Microsoft.Owin.Cors;
using Owin;

namespace SignalRSampleServer
{
    class AppStartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR("/device", new Microsoft.AspNet.SignalR.HubConfiguration());
        }
    }
}
