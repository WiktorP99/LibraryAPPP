using System.Collections.Generic;
using LibraryAPPP.DB.DTO;
using LibraryAPPP.Models;
using LibraryAPPP.Models.ViewModels;

namespace LibraryAPPP.Repository.LibraryRepository
{
    public interface ILibraryRepository
    {
        List<BookViewModel> GetAllBooks();
        List<Client> GetAllClients();
        List<BookViewModel> GetAllBooksToBuy(int clientId);
        public Book? GetBookById(int bookId);
        void AddBook(BookViewModel model);

    }
}