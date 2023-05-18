using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAPPP.DB.DTO;
using LibraryAPPP.Enums;
using LibraryAPPP.Models;
using LibraryAPPP.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AutoMapper;

namespace LibraryAPPP.Repository.LibraryRepository
{
    public class LibraryRepository : BaseRepository, ILibraryRepository
    {
        private readonly LibraryDBContext _context;
        protected override RepositoryType RepositoryType => RepositoryType.LibraryDB;

        public LibraryRepository(IConfiguration config, LibraryDBContext context) : base(config)
        {
            _context = context;
        }
        public List<BookViewModel> GetAllBooks()
        {
            var books = _context.Books.Include(x => x.Author).ToList();
            List<BookViewModel> resultList = new List<BookViewModel>();

            foreach (var book in books)
            {
                var bookViewModel = new BookViewModel
                {
                    AuthorFirstName = book.Author.AuthorFirstName,
                    AuthorLastName = book.Author.AuthorLastName,
                    Title = book.Title,
                    PublicationDate = book.PublicationDate.GetValueOrDefault(),
                    Price = book.Price,
                    Quantity = book.Quantity
                };
                resultList.Add(bookViewModel);
            }

            return resultList;
        }

        public List<Client> GetAllClients()
        {
            return _context.Clients.ToList();
        }

        public void AddBook(BookViewModel model)
        {
            try
            {
                Author author = _context.Authors.FirstOrDefault(a => a.AuthorFirstName == model.AuthorFirstName &&
                    a.AuthorLastName == model.AuthorLastName);

                if (author == null)
                {
                    author = new Author()
                    {
                        AuthorFirstName = model.AuthorFirstName,
                        AuthorLastName = model.AuthorLastName,
                    };
                    _context.Authors.Add(author);
                    _context.SaveChanges();
                }

                var existingBook = _context.Books.FirstOrDefault(b => b.Title == model.Title &&
                    b.Author.AuthorId == author.AuthorId);

                if (existingBook != null)
                {
                    existingBook.Quantity += model.Quantity;
                    existingBook.Price = model.Price;
                    existingBook.PublicationDate = model.PublicationDate;
                }
                else
                {
                    var book = new Book()
                    {
                        Title = model.Title,
                        Price = model.Price,
                        Quantity = model.Quantity,
                        PublicationDate = model.PublicationDate,
                        Author = author
                    };

                    _context.Books.Add(book);
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
