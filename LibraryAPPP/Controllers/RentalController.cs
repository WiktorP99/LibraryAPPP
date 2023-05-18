using LibraryAPPP.Repository.LibraryRepository;
using LibraryAPPP.Repository.RentRepository;
using LibraryAPPP.Repository.SalesOrderRepository;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPPP.Controllers
{
    public class RentalController : Controller
    {
        private readonly ILibraryRepository _libraryRepository;
        private readonly IRentRepository _rentRepository;

        public RentalController(ILibraryRepository libraryRepository, IRentRepository rentRepository)
        {
            _libraryRepository = libraryRepository;
            _rentRepository = rentRepository;
        }

        [HttpGet]
        [Route("[Controller]/Index/{clientId}")]
        public IActionResult Index(int clientId)
        {
            return View(_libraryRepository.GetAllBooks(clientId));
        }

        [HttpGet]
        [Route("[Controller]/RentBook/{clientId}/{bookId}")]
        public IActionResult RentBook(int clientId, int bookId)
        {
            _rentRepository.RentBook(bookId, clientId);
            return View("Index", _libraryRepository.GetAllBooksToBuy(clientId));
        }
    }
}