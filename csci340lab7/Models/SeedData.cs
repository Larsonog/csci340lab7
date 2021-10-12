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
                        Type = "Flavcado",
                        Tried = DateTime.Parse("2021-2-12"),
                        Enjoyment = "Very Yummy",
                        Price = 2.99M
                    },

                    new Avocado
                    {
                        Type = "California",
                        Tried = DateTime.Parse("2021-2-1"),
                        Enjoyment = "Super Good",
                        Price = 1.99M
                    },

                    new Avocado
                    {
                        Type = "Made in Mexico",
                        Tried = DateTime.Parse("2021-2-3"),
                        Enjoyment = "OK",
                        Price = 0.99M
                    },

                    new Avocado
                    {
                        Type = "Avocado",
                        Tried = DateTime.Parse("2021-3-12"),
                        Enjoyment = "Pretty Good",
                        Price = 1.50M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}