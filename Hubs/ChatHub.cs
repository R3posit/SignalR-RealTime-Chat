using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using Microsoft.AspNetCore.SignalR;

namespace Peeks.Hubs
{   
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
