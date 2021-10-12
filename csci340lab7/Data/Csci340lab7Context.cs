using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Csci340lab7.Models;

namespace Csci340lab7.Data
{
    public class Csci340lab7Context : DbContext
    {
        public Csci340lab7Context (DbContextOptions<Csci340lab7Context> options)
            : base(options)
        {
        }

        public DbSet<Csci340lab7.Models.Avocado> Avocado { get; set; }
    }
}
