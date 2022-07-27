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
