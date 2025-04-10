using Microsoft.VisualBasic.Devices;
using System.IO;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Runtime;

namespace myKSU.Models
{
    public class Student
    {
        private String ksuId             { get; set; }
        private String name              { get; set; }
        private String dob               { get; set; }

        private String major             { get; set; }
        private String standing          { get; set; }
        private String advisor           { get; set; }

        private String enrollStatus      { get; set; }
        private String enrollSemester    { get; set; }
        private double gpa               { get; set; }

        private String[]? previousCourses    { get; set; }
        private String[]? registeredCourses  { get; set; }

        private Schedule? schedule                { get; set; }
        private PaymentActivity? paymentActivity  { get; set; }
        private Profile? profile                  { get; set; }

        public Student()
        {
            String filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "studentData.json");

            if (File.Exists(filepath))
            {
                string jsonContent = File.ReadAllText(filepath);
                Student student = System.Text.Json.JsonSerializer.Deserialize<Student>(jsonContent);

                // auto-map JSON values to fields (field names and JSON key names MUST match!)
                this.ksuId = student.ksuId;
                this.name = student.name;
                this.dob = student.dob;

                this.major = student.major;
                this.standing = student.standing;
                this.advisor = student.advisor;

                this.enrollStatus = student.enrollStatus;
                this.enrollSemester = student.enrollSemester;
                this.gpa = student.gpa;

                this.previousCourses = student.previousCourses;
                this.registeredCourses = student.registeredCourses;

                this.schedule = null;           // will be set to a object after a class is enrolled
                this.paymentActivity = new PaymentActivity(ksuId); 
                this.profile = null;            // will be set to a object after profile is configured
            }
            else
            {
                // if file not found, assign defaults to fields
                this.ksuId = "N/A";
                this.name = "N/A";
                this.dob = "N/A";

                this.major = "N/A";
                this.standing = "N/A";
                this.advisor = "N/A";

                this.enrollStatus = "N/A";
                this.enrollSemester = "N/A";
                this.gpa = 0.0;

                this.previousCourses = ["N/A"];
                this.registeredCourses = ["N/A"];
            }
        }
    }
}