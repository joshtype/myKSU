using System;
using myKSU_v3;

namespace myKSU_v3.Library
{
    public class CourseManager
    {
        public List<Course> catalogFall2026 { get; set; } = new();

        //
        // ENROLL A COURSE
        //
        public string EnrollCourse(Student student, Course course, University university)
        {
            // dont allow if past add/drop deadlin
            var today = DateOnly.FromDateTime(DateTime.Now);
            if (today > university.addDropDeadline) 
                return "FAILURE: It is past the add/drop deadline.";

            // dont allow if already enrolled
            if (student.enrolledCourses.Any(c => c.code == course.code))
              return "FAILURE: You are already enrolled in this course.";

            // dont allow if course level > than student.standing
            int courseLevel = ExtractCourseLevel(course.code);
            int maxAllowed = MaxLevelPerStanding(student.standing);
            if(courseLevel > maxAllowed)
                return "FAILURE: course level is too high.";

            // otherwise, allow enrollment
            student.enrolledCourses.Add(course);
            return "SUCCESS";
        }


        //
        // UNENROLL A COURSE
        //
        public bool UnenrollCourse(Student student, Course course, University university)
        {
            var today = DateOnly.FromDateTime(DateTime.Now);

            if (today > university.addDropDeadline)
                return false; // Fail if past add/drop deadline

            if (!student.enrolledCourses.Any(c => c.code == course.code))
                return false; // Fail if student isn't enrolled

            student.enrolledCourses.RemoveAll(c => c.code == course.code); // Remove course

            DataLoader.SaveStudentData(student); // Save changes to file

            return true; // Unenrollment successful
        }


        //
        // SEARCH catalogFall2026 BY INPUT KEYWORD
        //
        public List<Course> SearchByKeyword(Student student, string keyword)
        {
            var matches = new List<Course>();
            foreach (var course in catalogFall2026)
            {
                if (!IsStudentEnrolled(student, course))
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

        // HELPER COURSE FOR SEARCHING BY KEYWORD
        private bool IsStudentEnrolled(Student student, Course course)
        {
            return student.enrolledCourses.Any(c => c.code == course.code);
        }


        //
        // GENERATE COURSE RECOMMENDATIONS
        //
        public List<Course> GenerateRecommendations(Student student)
        {
            // top 10 recommendations based on student's standing, matching previousCourses & prerequisites, sorted by matching major & dept
            var recommendations = new List<Course>();

            foreach (var course in catalogFall2026)
            {
                // FILTER 1: exclude courses enrolled currently or previously
                if (student.enrolledCourses.Any(c => c.code == course.code) ||
                    student.previousCourses.Any(c => c.code == course.code)) continue;

                // FILTER 2: exclude courses not available for student's standing
                if (ExtractCourseLevel(course.code) > MaxLevelPerStanding(student.standing)) continue;

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

        // HELPER COURSES FOR RECOMMENDED COURSES
        private int ExtractCourseLevel(string code)
        {
            string number = new string(code.Where(char.IsDigit).ToArray());
            return int.TryParse(number, out int level) ? level : 0;
        }
        private int MaxLevelPerStanding(string standing)
        {
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
