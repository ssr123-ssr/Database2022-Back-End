using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressSystem.Models
{
    public class Courier
    {
        [Key]
        public string COUR_ID { get; set; }

        public string NAME { get; set; }

        public string PHONE_NUMBER { get; set; }

        public string AREA { get; set; }

        public string COMP_ID { get; set; }

    }
}
