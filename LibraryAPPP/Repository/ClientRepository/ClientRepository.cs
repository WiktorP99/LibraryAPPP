using System.Linq;
using LibraryAPPP.DB.DTO;
using LibraryAPPP.Enums;
using LibraryAPPP.Models;
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
        public Client GetClientById(int ClientId)
        {
            return _context.Clients.FirstOrDefault(x => x.ClientId == ClientId);
        }

        public bool IsBlocked(int clientId)
        {
            return _context.Clients.FirstOrDefault(x => x.ClientId == clientId).Blocked;
        }
    }
}
