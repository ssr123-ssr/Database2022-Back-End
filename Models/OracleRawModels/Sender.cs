using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressSystem.Models
{
    public class Sender
    {
        [Key]
        public string ID { get; set; }

        public string SEND_ADDRESS { get; set; }

}
}