using Microsoft.AspNetCore.Mvc;

namespace LibraryAPPP.Controllers
{
    public class SalesOrderController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}