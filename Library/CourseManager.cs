using myKSU_v3.Library;
using System;

namespace myKSU_v3.Library
{
    public class CourseManager
    {
        public List<Course> catalogFall2026 { get; set; } = new();

        //
        // ENROLL & UNENROLL COURSES
        //
        public bool enrollCourse(Student student, Course course, University university)
        {
            var today = DateOnly.FromDateTime(DateTime.Now);

            if (today > university.addDropDeadline) return false;

            if (!student.enrolledCourses.Any(c => c.code == course.code))
            {
                student.enrolledCourses.Add(course);
                return true;
            }
            return false;
        }

        public bool unenrollCourse(Student student, Course course, University university)
        {
            var today = DateOnly.FromDateTime(DateTime.Now);

            if (today > university.addDropDeadline) return false;

            return student.enrolledCourses.RemoveAll(c => c.code == course.code) > 0 ;
        }
        
        //
        // SEARCH METHODS
        //
        public bool isStudentEnrolled(Student student, Course course)
        {
            // helper to check if student has enrolled the course already
            return student.enrolledCourses.Any(c => c.code == course.code);
        }
        public Course? searchByCode(string code)
        {
            // search for exact course codes
            foreach (var course in catalogFall2026)
            {
                if (course.code.Equals(code, StringComparison.OrdinalIgnoreCase)) return course;
            }
            return null;
        }
        public List<Course> searchByKeyword(Student student, string keyword)
        {
            // search course names and coded for argument keyword
            keyword = keyword.ToLower();
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

        //
        // COURSE RECOMMENDATIONS
        //
        private int extractCourseLevel(string code)
        {
            // helper to get course level from course code
            string number = new string(code.Where(char.IsDigit).ToArray());
            return int.TryParse(number, out int level) ? level : 0;
        }
        private int maxLevelPerStanding(string standing)
        {
            // helper to define course code levels per student class standings
            return standing.ToLower() switch
            {
                "freshman" => 1999,
                "sophomore" => 2999,
                "junior" => 3999,
                "senior" => 4999,
                _ => 2999           // default value for test student
            };
        }
        public List<Course> generateRecommendations(Student student)
        {
            // get top 10 recommended courses based on standing & prerequisites, sorted by major
            var recommendations = new List<Course>();

            foreach (var course in catalogFall2026)
            {
                // Filter 1: exclude courses enrolled currently or previously
                if (student.enrolledCourses.Any(c => c.code == course.code) ||
                    student.previousCourses.Any(c => c.code == course.code)) continue;

                // Filter 2: exclude courses not available for student's standing
                if (extractCourseLevel(course.code) > maxLevelPerStanding(student.standing)) continue;

                // Filter 3: exclude courses with prereqs not found in student's previousCourses list
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
        
    }
}
