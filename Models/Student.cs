using Microsoft.VisualBasic.Devices;
using System.IO;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
namespace myKSU.Models
{
    public class Student
    {
        private String ksuId             { get; set; }
        private String name              { get; set; }
        private String dob               { get; set; }
        private String major             { get; set; }
        private String standing          { get; set; }
        private double gpa               { get; set; }
        private String[] previousCourses { get; set; }

        public Student()
        {
            String filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "student.json");

            if (File.Exists(filepath))
            {
                string jsonContent = File.ReadAllText(filepath);
                Student student = System.Text.Json.JsonSerializer.Deserialize<Student>(jsonContent);

                // Initialize properties
                this.ksuId = student.ksuId;
                this.name = student.name;
                this.dob = student.dob;
                this.major = student.major;
                this.standing = student.standing;
                this.gpa = student.gpa;
                this.previousCourses = student.previousCourses;
            }
            else
            {
                throw new FileNotFoundException($"File not found at {filepath}");
            }
        }
    }
}