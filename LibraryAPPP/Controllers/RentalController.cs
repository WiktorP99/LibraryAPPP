using Microsoft.AspNetCore.Mvc;

namespace LibraryAPPP.Controllers
{
    public class RentalController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}