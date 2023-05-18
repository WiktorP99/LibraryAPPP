using Microsoft.AspNetCore.Mvc;

namespace LibraryAPPP.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            return View("blabla");
        }
    }
}
