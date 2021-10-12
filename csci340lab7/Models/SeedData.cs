using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Csci340lab7.Data;
using System;
using System.Linq;

namespace Csci340lab7.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Csci340lab7Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Csci340lab7Context>>()))
            {
                // Look for any movies.
                if (context.Avocado.Any())
                {
                    return;   // DB has been seeded
                }

                context.Avocado.AddRange(
                    new Avocado
                    {
                        ID = 1,
                        Triedon = DateTime.Parse("2021-2-4"),
                        Bigorsmall   = "small",
                        Price = 7.99M
                    },

                    new Avocado
                    {
                        ID = 2,
                        Triedon = DateTime.Parse("2021-2-3"),
                        Bigorsmall = "big",
                        Price = 7.99M
                    },

                    new Avocado
                    {
                        ID = 3,
                        Triedon = DateTime.Parse("2021-2-2"),
                        Bigorsmall = "big",
                        Price = 7.99M
                    },

                    new Avocado
                    {
                        ID = 4,
                        Triedon = DateTime.Parse("2021-2-1"),
                        Bigorsmall = "small",
                        Price = 7.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}