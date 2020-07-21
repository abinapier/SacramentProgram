using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentProgram.Models
{
    public class Speaker
    {
        public int ID { get; set; }

        [Display(Name = "Name")]
        public Person Person { get; set; }
        public Meeting Meeting { get; set; }
        public string Topic { get; set; }

        
    }
}
