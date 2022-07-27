using ExpressSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IClientRepository _clientRepository;


        public HomeController(ILogger<HomeController> logger, IClientRepository clientRepository)
        {
            _logger = logger;
            _clientRepository = clientRepository;
        }
 
        
        public IActionResult Index()
        {
            IEnumerable<Client> clients = _clientRepository.GerAllClients();
            return View(clients);
        }

        //[Authorize(Roles ="Admin")]
        public IActionResult Privacy()
        {
            return View();
        }

      

        #region  错误处理
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}
