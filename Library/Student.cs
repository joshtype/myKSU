using System;
using myKSU_v3;

namespace myKSU_v3.Library
{
    public class Student
    {
        public string ksuId { get; set; }
        public string name { get; set; }
        public string dob { get; set; }
        public string major { get; set; }
        public string standing { get; set; }
        public string gpa { get; set; }

        // CURRENT AND PREVIOUS COURSES
        public List<Course> previousCourses { get; set; }
        public List<Course> enrolledCourses { get; set; }

        // METHODS
        public Student() => enrolledCourses = new List<Course>();
        public override string ToString() => $"{name} [KSUID: {ksuId}]";
    }
}
