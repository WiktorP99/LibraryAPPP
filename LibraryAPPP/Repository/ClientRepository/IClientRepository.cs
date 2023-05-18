using LibraryAPPP.DB.DTO;
using LibraryAPPP.Models;
using LibraryAPPP.Models.ViewModels;

namespace LibraryAPPP.Repository.UserRepository
{
    public interface IClientRepository
    {
        public ClientDebtInfoViewModel GetClientById(int clientId);
        public bool IsBlocked(int clientId);
    }
}
