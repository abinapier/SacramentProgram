using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SacramentProgram.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime MeetingDate { get; set; }
        [Required]
        public Person Conducting { get; set; }
        [Required]
        public Person Presiding { get; set; }
        [Required]
        public Person Accompaniment { get; set; }
        [Required]
        public Person LeadingMusic { get; set; }
        [Required]
        public Song OpeningSong { get; set; }
        [Required]
        public Person OpeningPrayer { get; set; }
        [Required]
        public Song SacramentSong { get; set; }

        public MusicalNum MusicalNumber { get; set; }
        
        public Song IntermediateSong { get; set; }

        [Required]
        public Song ClosingSong { get; set; }
        [Required]
        public Person ClosingPrayerId { get; set; }
        [Required]
        public string WardName { get; set; }

        public ICollection<Speaker> Speakers { get; set; }
    }
}
