using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Back_End_wlf_01.Models.OraclePackageRepository;

namespace Back_End_wlf_01.Models
{
    public interface IPackageRepository
    {
        public IEnumerable<Package> GetAllPackage();

        public Package GetPackage(string id); 


        public string Delete(string id);

        public string Edit(string id);
    }
}
