using Microsoft.AspNetCore.Mvc;

namespace Signal_RR.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
