using System;
using myKSU_v3;

namespace myKSU_v3.Library
{
    public class Course
    {
        public string code { get;  set; }
        public string name { get; set; }
        public string description { get; set; }
        public string department { get; set; }
        public int credits { get; set; }
        public string type { get; set; }
        public int seatCap { get; set; }
        public List<string> prerequisites { get; set; } = new();
        public Dictionary<string, string>? meetingTimes { get; set; }  // ? = nullable (for online courses)

        // GETTERS (unnecessary but a couple of these are used elsewhere for clarity)
        public string getCode() { return this.code; }
        public string getName() { return this.name; }
        public string getDescription() { return this.description; }
        public string getDepartment() { return this.department; }
        public int getCredits() { return this.credits; }
        public string getType() { return this.type; }
        public int getSeatCap() { return this.seatCap; }
        public List<string> getPrerequisites() { return this.prerequisites; }
        public Dictionary<string, string> getMeetingTimes() { return this.meetingTimes; }

        // OVERRIDE OF TOSTRING()
        public override string ToString() { return $"{this.code}: {this.name} | {this.department} | {this.credits} credits | {this.type} | " +
                $"{this.description}"; }       
    }
}
