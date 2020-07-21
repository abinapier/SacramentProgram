using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SacramentProgram.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        [Display(Name = "Meeting Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime MeetingDate { get; set; }

        [Required]
        public Person Conducting { get; set; }

        [Required]
        public Person Presiding { get; set; }

        [Required]
        public Person Accompaniment { get; set; }

        [Display(Name = "Musical Conductor")]
        [Required]
        public Person LeadingMusic { get; set; }

        [Display(Name = "Opening Song")]
        [Required]
        public Song OpeningSong { get; set; }

        [Display(Name = "Opening Prayer")]
        [Required]
        public Person OpeningPrayer { get; set; }

        [Display(Name = "Sacrament Song")]
        [Required]
        public Song SacramentSong { get; set; }

        [Display(Name = "Musical Number")]
        public MusicalNum MusicalNumber { get; set; }

        [Display(Name = "Musical Number")]
        public Song IntermediateSong { get; set; }

        [Display(Name = "Closing Song")]
        [Required]
        public Song ClosingSong { get; set; }

        [Display(Name = "Closing Prayer")]
        [Required]
        public Person ClosingPrayerId { get; set; }

        [Display(Name = "Ward Name")]
        [Required]
        public string WardName { get; set; }

        public ICollection<Speaker> Speakers { get; set; }
    }
}
