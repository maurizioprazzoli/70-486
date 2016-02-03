using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRServer.PC
{
    class EchoConnection : PersistentConnection
    {
        public EchoConnection()
        {
            Console.WriteLine("EchoConnection class instantiate");
        }

        protected override Task OnConnected(IRequest request, string connectionId)
        {

            return Connection.Broadcast("Client connected " + connectionId);
        }
        protected override Task OnDisconnected(IRequest request, string connectionId, bool stopCalled)
        {
            return Connection.Broadcast("Client disconnected " + connectionId + " stopCalled " + (stopCalled ? "True" : "False"));
        }
        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            return Connection.Broadcast("Server received messager from client:" + connectionId);
        }
    }
}
