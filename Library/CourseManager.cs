using myKSU_v3.Library;
using System;

namespace myKSU_v3.Library
{
    public class CourseManager
    {
        public List<Course> catalogFall2026 { get; set; } = new();

        // Enroll a course
        public bool enrollCourse(Student student, Course course)
        {
            if (!student.enrolledCourses.Any(c => c.code == course.code))
            {
                student.enrolledCourses.Add(course);
                return true;
            }
            return false;
        }

        // Unenroll a course
        public bool unenrollCourse(Student student, Course course)
        {
            return student.enrolledCourses.RemoveAll(c => c.code == course.code) > 0 ;
        }

        // Search catalog by keyword
        public List<Course> searchByKeyword(Student student, string keyword)
        {
            keyword = keyword.ToLower();
            return catalogFall2026
                .Where(c => !student.enrolledCourses.Any(ec => ec.code == c.code))
                .Take(3)
                .ToList();
        }

        // Get recommended courses
        public List<Course> recommendedCourses(Student student)
        {
            return 
        }
    }
}
