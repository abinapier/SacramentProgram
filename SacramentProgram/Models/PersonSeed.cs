using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SacramentProgram.Data;
using SacramentProgram.Models;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class PersonSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentProgramContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacramentProgramContext>>()))
            {
                if (context.Person.Any())
                {
                    return;
                }

                context.Person.AddRange(
                    new Person
                    {
                        FirstName = "William",
                        LastName = "Brown",
                        BroOrSis = "Bishop"
                    },

                    new Person
                    {
                        FirstName = "Abi",
                        LastName = "Napier",
                        BroOrSis = "Sister"
                    },

                    new Person
                    {
                        FirstName = "Lauren",
                        LastName = "Thorne",
                        BroOrSis = "Sister"
                    },

                    new Person
                    {
                        FirstName = "Aaron",
                        LastName = "Wright",
                        BroOrSis = "Elder"
                    },

                    new Person
                    {
                        FirstName = "Brian",
                        LastName = "Warner",
                        BroOrSis = "Elder"
                    },

                    new Person
                    {
                        FirstName = "Jack",
                        LastName = "Johnson",
                        BroOrSis = "Brother"
                    },

                    new Person
                    {
                        FirstName = "Jim",
                        LastName = "Carrey",
                        BroOrSis = "Brother"
                    },

                    new Person
                    {
                        FirstName = "Mariah",
                        LastName = "Carrey",
                        BroOrSis = "Sister"
                    },

                    new Person
                    {
                        FirstName = "Cory",
                        LastName = "Taylor",
                        BroOrSis = "Brother"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
