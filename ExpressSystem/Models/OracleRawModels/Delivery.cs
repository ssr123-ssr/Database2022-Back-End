using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressSystem.Models
{
    public class Delivery
    {
        [Key]
        public string CLIE_ID { get; set; }

        public string COUR_ID { get; set; }
}
}
