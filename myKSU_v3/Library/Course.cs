using System;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
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

        public string GetCode() { return this.code; }
        public string GetName() { return this.name; }
        public string GetDescription() { return this.description; }
        public string GetDepartment() { return this.department; }
        public int GetCredits() { return this.credits; }
        public string GetType() { return this.type; }
        public int GetSeatCap() { return this.seatCap; }
        public Dictionary<string, string>? GetMeetingTimes() { return this.meetingTimes; }


        //
        // FORMAT STRING FOR DISPLAY FOR List<Course> Course.prerequisites
        //
        private string GetEachCourse(List<string> listCourse)
        {
            if (listCourse == null)
                return "no courses found";

            if (listCourse.Count == 1)
                return listCourse[0].ToString();

            string results = "";
            if (listCourse.Count > 1)
            {
                for (int i = 0; i < listCourse.Count; i++)
                {
                    results += listCourse[i].ToString();
                    if (i < listCourse.Count - 1) results += ", ";
                }
            }
            return results;
        }


        // OVERRIDE OF TOSTRING()
        public override string ToString() 
        {
            return $" [{this.code}: {this.name} / {this.type} / {this.credits} credits / PreReqs: {GetEachCourse(prerequisites)}] "; 
        }
    }
}
