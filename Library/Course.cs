using System;

namespace myKSU_v3.Library
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string department { get; set; }
      
        public int credits { get; set; }
        public int seatCap { get; set; }
        public List<string> prerequisites { get; set; } = new();
        public Dictionary<string, string>? meetingTimes { get; set; }  // ? = nullable (for online courses)

        public override string ToString() { return $"{code}: {name}, {department} department."; }
    }
}
