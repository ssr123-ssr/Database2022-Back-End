using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressSystem.Models
{
    public class Transportation
    {
        [Key]
        public string TRANS_ID { get; set; }

        public string TYPE { get; set; }

        public string CAPACITY { get; set; }

        public string POSITION { get; set; }

        public string CENTER_ID { get; set; }
}
}