﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentProgram.Models
{
    public class Speaker
    {
        public int ID { get; set; }
        public int PersonId { get; set; }
        public int MeetingId { get; set; }
        public string Topic { get; set; }
    }
}
