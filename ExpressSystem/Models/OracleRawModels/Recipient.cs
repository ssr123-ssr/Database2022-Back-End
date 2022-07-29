using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressSystem.Models
{
    public class Recipient
    {
        [Key]
        public string ID { get; set; }

        public string ACCEPT_ADDRESS { get; set; }
}
}