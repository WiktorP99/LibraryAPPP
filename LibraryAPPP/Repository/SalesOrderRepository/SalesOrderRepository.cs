using System;
using System.Collections.Generic;
using LibraryAPPP.DB.DTO;
using LibraryAPPP.Repository.LibraryRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LibraryAPPP.Repository.SalesOrderRepository
{
    public class SalesOrderRepository : ISalesOrderRepository
    {
        private readonly LibraryDBContext _context;
        private readonly ILibraryRepository _libraryRepository;
        public SalesOrderRepository(LibraryDBContext context, ILibraryRepository libraryRepository) 
        {
            _context = context;
            _libraryRepository = libraryRepository;
        }

        public void BuyBook(int bookId, int clientId)
        {
            var book = _libraryRepository.GetBookById(bookId);
            if (book == null)
            {
                throw new Exception("Book not found");
            }

            book.Quantity--;

            var orderHeader = new SalesOrderHeader
            {
                ClientId = clientId,
                OrderDate = DateTime.Now,
                DeliveryDate = DateTime.Now,
                SalesOrderStatusId = 1,
                SalesOrderDetails = new List<SalesOrderDetail>
                {
                    new SalesOrderDetail
                    {
                        BookId = bookId,
                        Amount = 1,
                        Price = book.Price.Value,
                    }
                }
            };

            SaveOrder(orderHeader, book);

        }

        public void OrderBook(int bookId, int clientId)
        {
            var book = _libraryRepository.GetBookById(bookId);
            if (book == null)
            {
                throw new Exception("Book not found");
            }

            book.Quantity--;

            var orderHeader = new SalesOrderHeader
            {
                ClientId = clientId,
                OrderDate = DateTime.Now,
                DeliveryDate = null,
                SalesOrderStatusId = 2,
                SalesOrderDetails = new List<SalesOrderDetail>
                {
                    new SalesOrderDetail
                    {
                        BookId = bookId,
                        Amount = 1,
                        Price = book.Price.Value,
                    }
                }
            };

            SaveOrder(orderHeader, book);
        }

        public void SaveOrder(SalesOrderHeader order, Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            _context.SalesOrderHeaders.Add(order);
            _context.SaveChanges();
        }
    }
}
