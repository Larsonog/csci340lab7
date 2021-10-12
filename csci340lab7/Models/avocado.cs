using System;
using System.ComponentModel.DataAnnotations;

namespace csci340lab7.avocado
{
    public class avocado
    {
        public int ID { get; set; }
        public string Type { get; set; }

        [DataType(DataType.Date)]
        public DateTime Discovery { get; set; }
        public string bigorsmall { get; set; }
        public decimal Price { get; set; }
    }
}