using Back_End_wlf_01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Back_End_wlf_01.Models.OraclePackageRepository;

namespace Back_End_wlf_01.Controllers
{
    public class CollectController : Controller
    {
        private readonly IPackageRepository _packageRepository;
        public CollectController(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }

        [HttpDelete]
        public string Delete(string id) 
        {
            return _packageRepository.Delete(id);
        }

        [HttpGet]
        public IEnumerable<Package> Get()
        {
            return _packageRepository.GetAllPackage();
        }

        public Package GetPackage(string id)
        {
            return _packageRepository.GetPackage(id);
        }

        [HttpPost]
        public string Edit(string id)
        {
            return _packageRepository.Edit(id);
        }




        //public string D()
        //{
        //    return "123";
        //}

    }
}
