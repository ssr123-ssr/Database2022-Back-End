using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressSystem.Models
{
    public class OracleDBContext:DbContext
    {
        public OracleDBContext(DbContextOptions<OracleDBContext> options) : base(options)
        {

        }

        //这里的就是数据库中的各个表
        //建议全部大写(包括Model中的各个property) 要不然容易抛奇怪的异常
        //因为oracle储存时候应该是把所有字符都转成大写
        public DbSet<User> USERS { get; set; }

        public DbSet<Client> CLIENT { get; set; }   
    }
}
