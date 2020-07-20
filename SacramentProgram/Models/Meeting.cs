using System;
using System.ComponentModel.DataAnnotations;

namespace SacramentProgram.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime meetingDate { get; set; }

        public int conductingId { get; set; }
        public int presidingId { get; set; }
        public int accompanimentId { get; set; }
        public int leadingMusicId { get; set; }
        public int songOneId { get; set; }
        public int openingPrayerId { get; set; }
        public int speakerOneId { get; set; }
        public int songTwoId { get; set; }
        public int speakerTwoId { get; set; }
        public int speakerThreeId { get; set; }
        public int songThreeId { get; set; }
        public int musicalNumberId { get; set; }
        public int closingPrayerId { get; set; }
        public string wardName { get; set; }
    }
}
