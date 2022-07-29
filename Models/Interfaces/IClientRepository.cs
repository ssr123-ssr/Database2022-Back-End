using Back_End_wlf_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressSystem.Models
{
    public interface IClientRepository
    {
        IEnumerable<Client> GerAllClients();
    }
}
