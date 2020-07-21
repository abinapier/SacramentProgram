using System;
using System.ComponentModel.DataAnnotations;

namespace SacramentProgram.Models
{
    public class Person
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Title")]
        public string BroOrSis { get; set; }
    }
}
