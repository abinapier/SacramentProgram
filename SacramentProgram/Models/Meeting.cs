using System;
using System.ComponentModel.DataAnnotations;

namespace SacramentProgram.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }

        public int ConductingId { get; set; }
        public int PresidingId { get; set; }
        public int AccompanimentId { get; set; }
        public int LeadingMusicId { get; set; }
        public int SongOneId { get; set; }
        public int OpeningPrayerId { get; set; }
        public int SpeakerOneId { get; set; }
        public int SongTwoId { get; set; }
        public int SpeakerTwoId { get; set; }
        public int SpeakerThreeId { get; set; }
        public int SongThreeId { get; set; }
        public int MusicalNumberId { get; set; }
        public int ClosingPrayerId { get; set; }
        public string WardName { get; set; }
    }
}
