using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SacramentProgram.Models;

namespace SacramentProgram.Data
{
    public class SacramentProgramContext : DbContext
    {
        public SacramentProgramContext (DbContextOptions<SacramentProgramContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentProgram.Models.Song> Song { get; set; }

        public DbSet<SacramentProgram.Models.Meeting> Meeting { get; set; }

        public DbSet<SacramentProgram.Models.Person> Person { get; set; }

        public DbSet<SacramentProgram.Models.Speaker> Speaker { get; set; }
    }
}
