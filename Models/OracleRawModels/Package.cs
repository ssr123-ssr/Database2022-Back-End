using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End_wlf_01.Models
{
    public class Package
    {
        [Key]
        public string PACK_ID { get; set; }

        public string STATE { get; set; }

        public string SENDER_ID { get; set; }

        public string RECIPIENT_ID { get; set; }

        public double WEIGHT { get; set; }

        public string ITEMS { get; set; }

        public double COST { get; set; }

        public string COUR_ID { get; set; }

        public string COMP_ID { get; set; }

        public string POST_ID { get; set; }

        public string CENTER_ID { get; set; }

        public string TRANS_ID { get; set; }
    }
}
