using System.Linq;
using LibraryAPPP.DB.DTO;
using LibraryAPPP.Repository.UserRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LibraryAPPP.Controllers
{
    public class ClientController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClientRepository _clientRepository;
        private readonly LibraryDBContext _context;

        public ClientController(IClientRepository clientRepository, LibraryDBContext context)
        {
            _clientRepository = clientRepository;
            _context = context;
        }
        [Route("[Controller]/Details/{clientId}")]
        public IActionResult Details(int clientId)
        {
            return View("ClientDetailsView", _clientRepository.GetClientById(clientId));
        }
    }
}