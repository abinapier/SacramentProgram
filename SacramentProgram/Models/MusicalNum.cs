using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentProgram.Models
{
    public class MusicalNum
    {
        public int ID { get; set; }

        [Display(Name = "Song Title")]
        public Song Song { get; set; }

        public string Performer { get; set; }

        [NotMapped]
        public string MusicalPerformance
        {
            get
            {
                var FullPerformance = Song.Name + " - " + Performer;
                return FullPerformance;
            }
        }

        [Display(Name = "Song Title")]
        public int SongID { get; set; }
    }
}