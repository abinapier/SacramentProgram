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
                    },

                    new Song
                    {
                        Name = "Rereemer of Isreal",
                        PageNum = 6
                    },

                    new Song
                    {
                        Name = "Isreal, Isreal, God is calling",
                        PageNum = 7
                    },

                    new Song
                    {
                        Name = "Awake and Arise",
                        PageNum = 8
                    },

                    new Song
                    {
                        Name = "Come, Rejoice",
                        PageNum = 9
                    },

                    new Song
                    {
                        Name = "Come, Sing to the Lord",
                        PageNum = 10
                    },

                    new Song
                    {
                        Name = "What was Witnessed in the Heavens?",
                        PageNum = 11
                    },

                    new Song
                    {
                        Name = "Twas Witnessed in the Morning Sky",
                        PageNum = 12
                    },

                    new Song
                    {
                        Name = "An Angel from on High",
                        PageNum = 13
                    },

                    new Song
                    {
                        Name = "Sweet Is the Peace the Gospel Brings",
                        PageNum = 14
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
