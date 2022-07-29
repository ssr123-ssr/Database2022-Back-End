using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressSystem.Models
{
    public class OracleUserRepository : IUserRepository
    {
        private readonly OracleDBContext context;

        public OracleUserRepository(OracleDBContext context)
        {
            this.context = context;
        }

        public User Add(User user)
        {
            context.USERS.Add(user);   //新用户信息添加到数据库中

            //为了验证update
            context.USERS.Find(user.ID).PASSWORD = "Update succeed";
                        
            context.SaveChanges();     //保存数据库更改
            return user;
        }

        public IEnumerable<User> GerAllUsers()
        {
            return context.USERS;
        }

        public User GetUser(string id)
        {
            return context.USERS.Find(id);
        }
    }
}
