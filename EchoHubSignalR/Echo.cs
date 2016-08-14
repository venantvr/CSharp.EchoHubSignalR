using SignalR.Hubs;

namespace EchoHubSignalR
{
    public class Echo : Hub
    {
        public void Send(string message)
        {
            Clients.addMessage(message);
        }
    }
}