using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressSystem.Models
{
    public class OracleClientRepository : IClientRepository
    {
        private readonly OracleDBContext context;

        public OracleClientRepository(OracleDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Client> GerAllClients()
        {
            //Linq查询
            var clientssss = context.CLIENT.Where<Client>(c => c.NAME == "于然");


            var clients = from Client c in context.CLIENT
                          join User u in context.USERS
                                 on c.ID equals u.ID
                          // where c.NAME == "于然"
                          select c;


                                                                    //只是大小写随意，  不要这么写
            var rawsql = context.CLIENT.FromSqlRaw("select client.id,name,phone_number from client,users where client.id = users.id");

               
            return clientssss;
        }
    }
}
