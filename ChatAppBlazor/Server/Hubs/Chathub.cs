using Microsoft.AspNetCore.SignalR;

namespace ChatAppBlazor.Server.Hubs

{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Console.WriteLine($"Message from {user}: {message}");
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
