using System;
using System.ComponentModel.DataAnnotations;

namespace SacramentProgram.Models
{
    public class MusicalNum
    {
        public int ID { get; set; }

        [Display(Name = "Song Title")]
        public Song Song { get; set; }

        public string Performer { get; set; }
    }
}