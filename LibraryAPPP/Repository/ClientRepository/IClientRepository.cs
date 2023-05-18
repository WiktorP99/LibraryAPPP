using LibraryAPPP.DB.DTO;
using LibraryAPPP.Models;

namespace LibraryAPPP.Repository.UserRepository
{
    public interface IClientRepository
    {
        public Client GetClientById(int clientId);
        public bool IsBlocked(int clientId);
    }
}
