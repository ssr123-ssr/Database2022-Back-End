using ExpressSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End_wlf_01.Models
{
    public class OracleDBContext:DbContext
    {
        public OracleDBContext(DbContextOptions<OracleDBContext> options) : base(options)
        {
        }

        public DbSet<Package> PACKAGE { get; set; }

        public DbSet<Recipient> RECIPIENT { get; set; }

        public DbSet<Client> CLIENT { get; set; }

        public DbSet<User> USERS { get; set; }
    }
}
