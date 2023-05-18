using LibraryAPPP.Repository.LibraryRepository;
using LibraryAPPP.Repository.SalesOrderRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LibraryAPPP.Controllers
{
    public class SalesOrderController : Controller
    {
        private readonly ILibraryRepository _libraryRepository;
        private readonly ISalesOrderRepository _salesOrderRepository;

        public SalesOrderController(ILibraryRepository libraryRepository, ISalesOrderRepository salesOrderRepository)
        {
            _libraryRepository = libraryRepository;
            _salesOrderRepository = salesOrderRepository;
        }

        [HttpGet]
        [Route("[Controller]/Index/{clientId}")]
        public IActionResult Index(int clientId)
        {
            return View(_libraryRepository.GetAllBooksToBuy(clientId));
        }

        [HttpGet]
        [Route("[Controller]/BuyBook/{clientId}/{bookId}")]
        public IActionResult BuyBook(int clientId, int bookId)
        {
            _salesOrderRepository.BuyBook(bookId, clientId);
            return View("Index",_libraryRepository.GetAllBooksToBuy(clientId));
        }

        [HttpGet]
        [Route("[Controller]/OrderBook/{bookId}/{clientId}")]
        public IActionResult OrderBook(int bookId, int clientId)
        {
            _salesOrderRepository.OrderBook(bookId, clientId);
            return View("Index", _libraryRepository.GetAllBooksToBuy(clientId));
        }
    }
}