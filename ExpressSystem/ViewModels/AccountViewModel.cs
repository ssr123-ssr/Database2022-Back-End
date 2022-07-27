using ExpressSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressSystem.ViewModels
{
    public class AccountViewModel
    {
        public User user { get; set; }

        public int registerStatus { get; set; }

    }
}
