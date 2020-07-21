﻿using System;

namespace SacramentProgram.Models
{
    public class MusicalNum
    {
        public int ID { get; set; }
        public Song Song { get; set; }
        public string Performer { get; set; }
        public string MusicalPerformance
        {
            get
            {
                var FullPerformance = Song + " " + Performer + " ";
                return FullPerformance;
            }
        }
    }
}