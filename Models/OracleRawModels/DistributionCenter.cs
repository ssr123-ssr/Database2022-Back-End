using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressSystem.Models
{
    public class DistributionCenter
    {
        [Key]
        public string CENTER_ID { get; set; }

        public string NAME { get; set; }

        public string ADDRESS { get; set; }

        public int CAPACITY { get; set; }

        public string COMP_ID { get; set; }
       } 
}
