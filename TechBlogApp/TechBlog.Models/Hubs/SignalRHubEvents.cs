using Microsoft.AspNetCore.SignalR;
using TechBlog.Models.Hubs;

namespace LeadingEdgeServer.Models.Hubs
{
    public static class SignalRHubEvents
    {
        public static async Task SetHubEvent(IHubContext<MessageHub> _hubContext, string connectionId, string eventName, HubResponseDto response)
        {
            if (!string.IsNullOrEmpty(connectionId))
            {
                await _hubContext.Clients.Client(connectionId).SendAsync(eventName, response);
            }
            else
            {
                await _hubContext.Clients.All.SendAsync(eventName, response);
            }
        }

        public static async Task SetHubEventToUsers(IHubContext<MessageHub> _hubContext, List<string> connectionIds, string eventName, HubResponseDto response)
        {
            if (connectionIds != null && connectionIds.Any())
            {
                await _hubContext.Clients.Clients(connectionIds).SendAsync(eventName, response);
            }
            else
            {
                await _hubContext.Clients.All.SendAsync(eventName, response);
            }
        }
    }
}