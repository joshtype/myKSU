using System;
using myKSU_v3;

namespace myKSU_v3.Library
{
    public class CourseManager
    {
        public List<Course> catalogFall2026 { get; set; } = new();

        // ENROLL A COURSE
        public string enrollCourse(Student student, Course course, University university)
        {
            // dont allow if past add/drop deadlin
            var today = DateOnly.FromDateTime(DateTime.Now);
            if (today > university.addDropDeadline) 
                return "FAILURE: It is past the add/drop deadline.";

            // dont allow if already enrolled
            //if (student.enrolledCourses.Any(c => c.code == course.code))
              //  return "FAILURE: You are already enrolled in this course.";

            // dont allow if course level > than student.standing
            int courseLevel = extractCourseLevel(course.code);
            int maxAllowed = maxLevelPerStanding(student.standing);
            if(courseLevel > maxAllowed)
                return "FAILURE: course level is too high.";

            // otherwise, allow enrollment
            student.enrolledCourses.Add(course);
            return "SUCCESS";
        }

        // UNENROLL A COURSE
        public string unenrollCourse(Student student, Course course, University university)
        {
            var today = DateOnly.FromDateTime(DateTime.Now);

            // do not allow if current date is past add/drop deadline
            if (today > university.addDropDeadline)
                return "FAILURE: It is past the add/drop deadline.";

            // do not allow if he student is not enrolled in the course 
            if (student.enrolledCourses.Any(c => c.code == course.code))
                return "FAILURE: You are not enrolled in this course.";

            return "SUCCESS";
        }

        // SEARCH catalogFall2026 BY INPUT KEYWORD
        public List<Course> searchByKeyword(Student student, string keyword)
        {
            // search course names and codes for argument keyword
            var matches = new List<Course>();

            foreach (var course in catalogFall2026)
            {
                if (!isStudentEnrolled(student, course))
                {
                    bool codeMatch = course.code.ToLower().Contains(keyword);
                    bool nameMatch = course.name.ToLower().Contains(keyword);

                    if (codeMatch || nameMatch)
                    {
                        matches.Add(course);
                    }
                }
            }
            return matches;
        }
        private bool isStudentEnrolled(Student student, Course course)
        {
            // Helper to check if student is currently enrolled in the course
            return student.enrolledCourses.Any(c => c.code == course.code);
        }


        // GENERATE COURSE RECOMMENDATIONS
        public List<Course> generateRecommendations(Student student)
        {
            // get top 10 recommended courses based on standing & prerequisites, sorted by major
            var recommendations = new List<Course>();

            foreach (var course in catalogFall2026)
            {
                // FILTER 1: exclude courses enrolled currently or previously
                if (student.enrolledCourses.Any(c => c.code == course.code) ||
                    student.previousCourses.Any(c => c.code == course.code)) continue;

                // FILTER 2: exclude courses not available for student's standing
                if (extractCourseLevel(course.code) > maxLevelPerStanding(student.standing)) continue;

                // FILTER 3: exclude courses with prereqs not found in student's previousCourses list
                if (course.prerequisites != null && course.prerequisites.Any(p =>
                    p != "None" && !student.previousCourses.Any(pc =>
                    pc.code.Equals(p, StringComparison.OrdinalIgnoreCase)))) continue;

                // catalog has been filtered
                recommendations.Add(course);
            }
            // sort to front courses where course department == student major
            var sortedCourses = recommendations
                .OrderByDescending(c => c.department.Equals(student.major, StringComparison.OrdinalIgnoreCase))
                .ThenBy(c => c.code)
                .Take(10)
                .ToList();
            return sortedCourses;
        }
        private int extractCourseLevel(string code)
        {
            // Helper to get course level from course code
            string number = new string(code.Where(char.IsDigit).ToArray());
            return int.TryParse(number, out int level) ? level : 0;
        }
        private int maxLevelPerStanding(string standing)
        {
            // Helper to define course code levels per student class standings
            return standing.ToLower() switch
            {
                "freshman" => 1999,
                "sophomore" => 2999,
                "junior" => 3999,
                "senior" => 4999,
                _ => 2999           // default value for test student
            };
        }
    }
}
