using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csci340lab7.Models
{
    public class Avocado
    {
        public int ID { get; set; }
        public string Type { get; set; }

        [DataType(DataType.Date)]
        public DateTime Tried { get; set; }
        public string Enjoyment { get; set; }
        public decimal Price { get; set; }
    }
}