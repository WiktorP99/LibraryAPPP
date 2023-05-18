using System.Collections.Generic;
using LibraryAPPP.Models.ViewModels;
using LibraryAPPP.Repository.LibraryRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LibraryAPPP.Controllers
{
    public class BooksController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILibraryRepository _libraryRepository;
        public BooksController(ILogger<HomeController> logger, ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
            _logger = logger;
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
            return View("AddBookView", model);
        }

        public ActionResult BookAdded()
        {
            return View("AddBookView");
        }

    }
}
