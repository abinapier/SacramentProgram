using System;

namespace SacramentProgram.Models
{
    public class Speaker
    {
        public int ID { get; set; }
        public Person Person { get; set; }
        public Meeting Meeting { get; set; }
        public string Topic { get; set; }
    }
}
