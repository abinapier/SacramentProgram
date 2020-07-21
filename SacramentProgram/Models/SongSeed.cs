using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SacramentProgram.Data;
using SacramentProgram.Models;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class SongSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentProgramContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacramentProgramContext>>()))
            {
                if (context.Song.Any())
                {
                    return;
                }

                context.Song.AddRange(
                    new Song
                    {
                        Name = "The Morning Breaks",
                        PageNum = 1
                    },

                    new Song
                    {
                        Name = "The Spirit of God",
                        PageNum = 2
                    },

                    new Song
                    {
                        Name = "Now Let Us Rejoice",
                        PageNum = 3
                    },

                    new Song
                    {
                        Name = "Truth Eternal",
                        PageNum = 4
                    },

                    new Song
                    {
                        Name = "Redeemer of Isreal",
                        PageNum = 5
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
