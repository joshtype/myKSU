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

        public List<Course> previousCourses { get; set; }
        public List<Course> enrolledCourses { get; set; }

        public Student()
        {
            enrolledCourses = new List<Course>();
            previousCourses = new List<Course>();
        }
            
        public override string ToString()
        {
            return $"{name} (KSUID: {ksuId}) / DOB: {dob} / Major: {major} / Class Standing: {standing} / GPA: {gpa}.";
        }
    }
}
