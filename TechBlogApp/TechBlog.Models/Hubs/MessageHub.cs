using LeadingEdgeServer.Models.Request.UserConnections;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System.Text;

namespace TechBlog.Models.Hubs
{
    [AllowAnonymous]
    public class MessageHub : Hub
    {
        public async Task SendResponse(string responseMsg)
        {
            await Clients.Caller.SendAsync("ResponseCode", responseMsg);
        }

        public string GetConnectionId()
        {
            return Context.ConnectionId;
        }

        public override Task OnConnectedAsync()
        {
            var connectionId = Context.ConnectionId;
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            var connectionId = Context.ConnectionId;
            //GenerateOnDisConnectedEvent();
            return base.OnDisconnectedAsync(exception);
        }

        public async Task GenerateOnDisConnectedEvent()
        {
            //UserConnectionRequestDto data = new UserConnectionRequestDto();
            //data.ConnectionId = Context.ConnectionId;
            //data.IsActive = false;
            //var jsonInString = JsonConvert.SerializeObject(data);
            //var client = new HttpClient();
            //var apiURL = ServerConfigurations.APIServerBaseUrl + "ManageUserConnections/updateUserConnection";
            //var result = await client.PutAsync(apiURL, new StringContent(jsonInString, Encoding.UTF8, "application/json"));
        }

        //private readonly static ConnectionMapping<string> _connections =
        //  new ConnectionMapping<string>();

        //public async Task SendChatMessageAsync(string who, string message)
        //{
        //    string name = Context.User.Identity.Name;

        //    foreach (var connectionId in _connections.GetConnections(who))
        //    {
        //        await Clients.Client(connectionId).SendAsync(name + ": " + message);
        //    }
        //}

        //public override Task OnConnectedAsync()
        //{
        //    string name = Context.User.Identity.Name;

        //    _connections.Add(name, Context.ConnectionId);
        //    return base.OnConnectedAsync();
        //}

        //public override Task OnDisconnectedAsync(Exception ex)
        //{
        //    string name = Context.User.Identity.Name;

        //    _connections.Remove(name, Context.ConnectionId);
        //    return base.OnDisconnectedAsync(ex);
        //}
        //public override Task OnDisconnected(bool stopCalled)
        //{
        //    return base.OnDisconnected(stopCalled);
        //}

        //public override Task OnReconnected()
        //{
        //    string name = Context.User.Identity.Name;

        //    if (!_connections.GetConnections(name).Contains(Context.ConnectionId))
        //    {
        //        _connections.Add(name, Context.ConnectionId);
        //    }

        //    return base.OnReconnected();
        //}
    }
}