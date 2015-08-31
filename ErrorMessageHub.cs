using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using ErrorManager.DTO;

namespace ErrorManager.Hub.Hubs
{
    public class ErrorManagerHub : Microsoft.AspNet.SignalR.Hub
    {
        public void UpdateError(ErrorDTO error)
        {
            Clients.All.updateError(error);
        }

        public void CreateError(ErrorDTO error)
        {
            Clients.All.createError(error);
        }

        public void RemoveError(ErrorDTO error)
        {
            Clients.All.removeError(error);
        }

        public override Task OnConnected()
        {
            Debug.WriteLine("Client connected: " + Context.ConnectionId);
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            Debug.WriteLine("Client disconnected: " + Context.ConnectionId);
            return base.OnDisconnected(stopCalled);
        }
    }
}