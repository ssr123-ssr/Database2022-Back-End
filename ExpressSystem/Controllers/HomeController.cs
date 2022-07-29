using ExpressSystem.Models;
using ExpressSystem.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Microsoft.AspNetCore.Http;

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

        private string ToJson(object obj)
        {
            lock(obj)
            {
                try
                {
                    return JsonConvert.SerializeObject(obj);
                }
                catch { }
                return null;   //异常返回null
            }
        }

        //[Authorize(Roles ="Admin")]
        public IActionResult Privacy()
        {       
            AccountMessage accountMessage = new AccountMessage();      
            accountMessage.data["ID"] = "12345";

            TestModel test = new TestModel();
            test.json_test = ToJson(accountMessage);

            //Client b = new Client();
            //b = JsonConvert.DeserializeObject<Client>(homePrivacyViewModel.json_test);
            //可以这么解析 但是会带一些其他的数据 因此进行挨个赋值比较好吧可能  
            //b.ID = Request.Form["ID"];   //学长例子是这么写的  具体request应该就是前端发回来的数据

            return View(test);          
        }

        [HttpGet]
        public string Test()
        {
            AccountMessage accountMessage = new AccountMessage();

            return accountMessage.ToJson();
        }

        [HttpPost]
        public string Test(string create)
        {                     
            
            AccountMessage accountMessage = new AccountMessage();
            accountMessage.data["ROLE"] = Request.Form["id"];

            return accountMessage.ToJson();                      
        }

        [HttpPut]
        public string Test(int update)
        {
            AccountMessage accountMessage = new AccountMessage();
            accountMessage.data["ROLE"] = Request.Form["id"];

            return accountMessage.ToJson();
        }

        [HttpDelete]
        public string Test(double delete)
        {
            AccountMessage accountMessage = new AccountMessage();
            accountMessage.data["ROLE"] = Request.Form["id"];

            return accountMessage.ToJson();
        }
    }
}
