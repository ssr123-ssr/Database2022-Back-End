using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressSystem.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> GerAllUsers();

        User Add(User user);

        User GetUser(string iD);
    }
}
