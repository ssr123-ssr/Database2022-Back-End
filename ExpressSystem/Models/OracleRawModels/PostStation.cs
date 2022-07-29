using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressSystem.Models
{
    public class PostStation
    {
        [Key]
        public string POST_ID { get; set; }

        public string NAME { get; set; }

        public string ADDRESS { get; set; }

        public string PHONE_NUMBER { get; set; }
}
}