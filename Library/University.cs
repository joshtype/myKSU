using System;
using myKSU_v3;

namespace myKSU_v3.Library
{
    public class University
    {
        public string name { get; set; }
        public string address { get; set; }
        public string semester { get; set; }
        public DateOnly addDropDeadline { get; set; }
        public Dictionary<string, Office> offices { get; set; } // key = office name, value = Office object
    }
}

