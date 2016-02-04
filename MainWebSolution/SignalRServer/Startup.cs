using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using SignalRServer.PC;
using Microsoft.Owin.Cors;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(SignalRServer.Startup))]

namespace SignalRServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.MapSignalR<EchoConnection>("/echo");
            app.Map("/echo",
                                    map =>
                                    {
                                        map.UseCors(CorsOptions.AllowAll);
                                        map.RunSignalR<EchoConnection>();
                                    }
                                    );
        }
    }
}
