using Microsoft.AspNetCore.SignalR;
using System.Runtime.CompilerServices;

namespace BlazorWebAppChatApp.ChatHub
{
    public class ChatApp : Hub
    {
        public async Task Broadcast(string username, string message)
        {
            await Clients.All.SendAsync("Broadcast", username, message);
        }
    }
}
