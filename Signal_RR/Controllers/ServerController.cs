using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Signal_RR.Hubs;
using System.Threading.Tasks;

namespace SignalRApp.Controllers
{
    public class ServerController : Controller
    {
        private readonly IHubContext<ChatHub> _hubContext;

        public ServerController(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(string user, string message)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveMessage", user, message);
            return RedirectToAction("Index");
        }
    }
}
