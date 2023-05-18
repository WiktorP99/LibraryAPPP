using System.Collections.Generic;
using System.Linq;
using LibraryAPPP.DB.DTO;
using LibraryAPPP.Enums;
using LibraryAPPP.Models;
using LibraryAPPP.Models.ViewModels;
using Microsoft.Extensions.Configuration;

namespace LibraryAPPP.Repository.UserRepository
{
    public class ClientRepository : BaseRepository, IClientRepository
    {
        protected override RepositoryType RepositoryType => RepositoryType.LibraryDB;
        private readonly LibraryDBContext _context;

        public ClientRepository(IConfiguration config, LibraryDBContext context) : base(config)
        {
            _context = context;
        }
        public ClientDebtInfoViewModel GetClientById(int clientId)
        {
            var debtDetails = (from client in _context.Clients
                where client.ClientId == clientId
                from rentHeader in client.RentHeaders.DefaultIfEmpty()
                from rentDetail in rentHeader.RentDetails.DefaultIfEmpty()
                select new ClientDebtDetailModel
                {
                    ReturnDate = rentHeader.ReturnDate,
                    PenaltyFee = rentDetail.PenaltyFee,
                    DelayDays = rentDetail.DelayDays,
                    BookTitle = rentDetail.Book.Title,
                    AuthorFirstName = rentDetail.Book.Author.AuthorFirstName,
                    AuthorLastName = rentDetail.Book.Author.AuthorLastName
                }).ToList();

            var clientInfo = (from client in _context.Clients
                where client.ClientId == clientId
                select new ClientDebtInfoViewModel
                {
                    Client = client,
                    DebtDetails = debtDetails
                }).FirstOrDefault();


            return clientInfo;
        }
        public List<Client> GetAllClients()
        {
            return _context.Clients.ToList();
        }
        public bool IsBlocked(int clientId)
        {
            return _context.Clients.FirstOrDefault(x => x.ClientId == clientId).Blocked;
        }
    }
}
