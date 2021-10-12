using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Csci340lab7.Models
{
    public class Avocado
    {
        public int ID { get; set; }
        public string Type { get; set; }

        [DataType(DataType.Date)]
        public DateTime Triedon { get; set; }
        public string Bigorsmall { get; set; }
        public decimal Price { get; set; }
    }
}
