using LibraryAPPP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LibraryAPPP.Models.ViewModels;
using LibraryAPPP.Repository.LibraryRepository;
using Microsoft.Extensions.Configuration;

namespace LibraryAPPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILibraryRepository _libraryRepository;
        public HomeController(ILogger<HomeController> logger, ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_libraryRepository.GetAllClients());
        }

        public IActionResult GetBooks()
        {
            List<BookViewModel> list = new List<BookViewModel>();
            list = _libraryRepository.GetAllBooks();

            return View("BooksView", list);
        }

        [Route("[Controller]/AddBook")]
        public ActionResult AddBook(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                BookViewModel newBook = new BookViewModel
                {
                    AuthorFirstName = model.AuthorFirstName,
                    AuthorLastName = model.AuthorLastName,
                    Title = model.Title,
                    PublicationDate = model.PublicationDate,
                    Price = model.Price,
                    Quantity = model.Quantity
                };
                if (newBook.AuthorFirstName != null && newBook.AuthorLastName != null && newBook.Title != null)
                {
                    _libraryRepository.AddBook(newBook);
                    return RedirectToAction("BookAdded");
                }
                else
                {
                    return RedirectToAction("BookAdded");
                }

            }
            return View("Index", model);
        }

        public ActionResult BookAdded()
        {
            return View("AddBookView");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
