using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentProgram.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        [Display(Name = "Meeting Date")]
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }

        
        public Person Conducting { get; set; }

        
        public Person Presiding { get; set; }

        
        public Person Accompaniment { get; set; }

        [Display(Name = "Musical Conductor")]
        
        public Person LeadingMusic { get; set; }

        [Display(Name = "Opening Song")]
        
        public Song OpeningSong { get; set; }

        [Display(Name = "Opening Prayer")]
        
        public Person OpeningPrayer { get; set; }

        [Display(Name = "Sacrament Song")]
        
        public Song SacramentSong { get; set; }

        [Display(Name = "Musical Number")]
        public MusicalNum MusicalNumber { get; set; }

        [Display(Name = "Musical Number")]
        public Song IntermediateSong { get; set; }

        [Display(Name = "Closing Song")]
        
        public Song ClosingSong { get; set; }

        [Display(Name = "Closing Prayer")]
        
        public Person ClosingPrayerId { get; set; }

        [Display(Name = "Ward Name")]
        
        public string WardName { get; set; }

        public ICollection<Speaker> Speakers { get; set; }

        public int ConductingID { get; set; }
        public int PresidingID { get; set; }
        public int AccompanimentID { get; set; }
        public int LeadingMusicID { get; set; }
        public int OpeningSongID { get; set; }
        public int OpeningPrayerID { get; set; }
        public int SacramentSongID { get; set; }
        public int? MusicalNumberID { get; set; }
        public int IntermediateSongID { get; set; }
        public int ClosingSongID { get; set; }
        public int ClosingPrayerIdID { get; set; }

        [NotMapped]
        public string Testing
        {
            get
            {
                var Testing = MeetingDate.ToLongDateString();
                return Testing;
            }
        }

    }
}
