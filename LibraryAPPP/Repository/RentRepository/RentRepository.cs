using System;
using System.Collections.Generic;
using LibraryAPPP.DB.DTO;
using LibraryAPPP.Repository.LibraryRepository;
using LibraryAPPP.Repository.UserRepository;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPPP.Repository.RentRepository
{
    public class RentRepository : IRentRepository
    {
        private readonly LibraryDBContext _context;
        private readonly ILibraryRepository _libraryRepository;
        private readonly IClientRepository _clientRepository;
        public RentRepository(LibraryDBContext context, ILibraryRepository libraryRepository, IClientRepository clientRepository)
        {
            _context = context;
            _libraryRepository = libraryRepository;
            _clientRepository = clientRepository;
        }

        public void RentBook(int bookId, int clientId)
        {
            try
            {
                if (!_clientRepository.IsBlocked(clientId))
                {
                    var book = _libraryRepository.GetBookById(bookId);
                    if (book == null)
                    {
                        throw new Exception("Book not found");
                    }

                    book.Quantity--;

                    var orderHeader = new RentHeader()
                    {
                        ClientId = clientId,
                        RentDate = DateTime.Now,
                        ReturnDate = DateTime.Now.AddDays(30),
                        RentStatusId = 1, //Rented 
                        RentDetails = new List<RentDetail>
                        {
                            new RentDetail
                            {
                                BookId = bookId,
                                Amount = 1,
                                DelayDays = 0,
                                PenaltyFee = 0
                            }
                        }
                    };
                    SaveOrder(orderHeader, book);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void SaveOrder(RentHeader order, Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            _context.RentHeaders.Add(order);
            _context.SaveChanges();
        }
    }
}
