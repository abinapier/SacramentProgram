using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentProgram.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BroOrSis { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                var FullPerson = BroOrSis + " " + FirstName + " " +LastName;
                return FullPerson;
            }
        }
    }
}
