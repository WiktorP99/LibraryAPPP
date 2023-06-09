﻿using LibraryAPPP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LibraryAPPP.Models.ViewModels;
using LibraryAPPP.Repository.LibraryRepository;
using LibraryAPPP.Repository.UserRepository;
using Microsoft.Extensions.Configuration;

namespace LibraryAPPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClientRepository _clientRepository;
        public HomeController(ILogger<HomeController> logger, IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_clientRepository.GetAllClients());
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
