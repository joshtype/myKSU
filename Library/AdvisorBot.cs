using System;
using System.CodeDom;
using System.Security.Authentication.ExtendedProtection;
using myKSU_v3;

namespace myKSU_v3.Library 
{
    public class AdvisorBot
    {
        private Student student;
        private CourseManager courseManager;
        private University university;

        private List<string> studyTips = new List<string>
        {
            "Use Active Recall – Instead of re-reading notes, quiz yourself to strengthen memory.",
            "Pomodoro Technique – Study for 25 minutes, then take a 5-minute break to stay fresh.",
            "Teach Someone Else – Explaining concepts helps reinforce understanding.",
            "Space Out Your Learning – Avoid cramming! Study a little each day to improve retention.",
            "Create a Distraction-Free Zone – Silence notifications and keep your workspace organized."
        };
        private List<string> jokes = new List<string>
        {
            "Why did the student eat his homework? Because his teacher said it was a piece of cake!",
            "Why can’t you trust an atom? Because they make up everything!",
            "Why was the geometry book so adorable? It had so many acute angles!",
            "What’s a computer’s favorite snack? Microchips!",
            "Why was the equal sign so humble? Because it never wanted to be greater than or less than anyone else."
        };

        public AdvisorBot(Student s, CourseManager cm, University u)        
        {           
            this.student = s;         // s = student's data (id, major, enrolledCourses list, previousCourses list, etc)
            this.courseManager = cm;  // cm = 'catalogFall2026', a list of Course objects available for Fall 2026
        }

        // MATCH UNIVERSITY FIELDS WITH INPUT KEYWORD
        public string getUniversityData(string input)
        {
            input = input.ToLower();

            if (input.Contains("university name"))
                return $"Hoot! The university's name is {university.name}.";

            if (input.Contains("campus"))
                return $"Hoot! The main campus is located at {university.Ccmpus}.";

            if (input.Contains("address"))
                return $"Hoot! The university address is {university.address}.";

            if (input.Contains("semester"))
                return $"Hoot! The current semester is {university.semester}.";

            if (input.Contains("add/drop deadline"))
                return $"Hoot! The add/drop deadline for this semester is {university.addDropDeadline}.";

            return null;  // no university field found
        }

        // MATCH OFFICE WITH INPUT KEYWORD
        public string getOfficeContactInfo(string input)
        {
            input = input.ToLower();

            foreach (var officeEntry in university.offices)
            {
                if (input.Contains(officeEntry.Key.ToLower()))
                {
                    var office = officeEntry.Value;
                    return $"Hoot! Here’s the contact info for {office.name}:\n" +
                           $"- Phone: {office.phone}\n" +
                           $"- Email: {office.hours}\n" +
                           $"- Location: {office.location}";
                }
            }
            return null;  // no office found
        }

        // MATCH COURSE CODE OR NAME WITH INPUT KEYWORD
        public string matchCourse(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "Hoot! You forgot to ask me a question!";

            input = input.Trim().ToLower();
            foreach (var course in courseManager.catalogFall2026)
            {
                if (input.Contains(course.code.ToLower()) || input.Contains(course.name.ToLower()))
                    return course.ToString();
            }
            return null;  // no course found
        }

        // MATCH STUDENT DATA FIELD WITH INPUT KEYWORD
        public string matchStudentData(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "Hoot! You forgot to ask me a question!";

            input = input.ToLower();
            if (input.Contains("gpa")) 
                return $"Your current GPA is {student.gpa:F2}. You got this!";

            if (input.Contains("major")) 
                return $"Your major is {student.major}. Great choice!";

            if (input.Contains("standing")) 
                return $"Your current class standing is {student.standing}. Almost there!";

            if (input.Contains("id")) 
                return $"Your KSU ID is {student.ksuId}.";

            return null;  // no student field found
        }

        // GET STUDENT'S ENROLLED COURSES
        public string matchEnrolledCourses(string input)
        {
            if (courseManager.catalogFall2026 == null || !courseManager.catalogFall2026.Any())
                return "Hoot! I couldn't find any courses in the catalog!";

            input = input.ToLower();
            foreach (var enrolledCourse in student.enrolledCourses)  // Fix: 'enrolledCourse' is a Course object
            {
                var course = courseManager.catalogFall2026
                    .FirstOrDefault(c => string.Equals(enrolledCourse.code, c.code, StringComparison.OrdinalIgnoreCase));

                if (course != null && (input.Contains(course.code.ToLower()) || input.Contains(course.name.ToLower())))
                    return $"Hoot! You are currently enrolled in {course.ToString()}. Remember to study hard!";
            }
            return null;
        }

        // GET STUDENT'S PREVIOUS COURSES 
        public string matchPreviousCourses(string input)
        {
            if (courseManager.catalogFall2026 == null || !courseManager.catalogFall2026.Any())
                return "Hoot! I couldn't find any courses in the catalog!";

            input = input.ToLower();
            foreach (var enrolledCourse in student.enrolledCourses)  // Fix: 'enrolledCourse' is a Course object
            {
                var course = courseManager.catalogFall2026
                    .FirstOrDefault(c => string.Equals(enrolledCourse.code, c.code, StringComparison.OrdinalIgnoreCase));

                if (course != null && (input.Contains(course.code.ToLower()) || input.Contains(course.name.ToLower())))
                    return $"Hoot! You are currently enrolled in {course.ToString()}. Remember to study hard!";
            }
            return null;
        }

        // COMBINE KEYWORD SEARCHES
        private static Random random = new Random();
        public string parseChatbotReply(string input)
        { 
            // campus police
            if (input.Contains("police") || input.Contains("campus police") || input.Contains("call police"))
                return "The campus police phone number is 770-423-6666. Call 911 if there is an emergency!";

            // chatbot help
            if (input.Contains("help") || input.Contains("need help") || input.Contains("how to use digital advisor") ||
                input.Contains("how to use chatbot"))
                return "Hoot! Sure, I can help! I have a lot of info about you and KSU. You can ask questions like . " 
                + "'What is my GPA?' / 'Am I enrolled in MATH2100?' / 'When is the add/drop deadline?' / 'When does the library close? / etc. '"
                + "Or, you can enter keywords like 'gpa' / 'previous courses' / 'current courses' / 'Bursars office' / etc. "
                + "\nIf I don't know something that I should, try rewording your question or using a different keyword! Hoot!";

            // random joke
            if (input.Contains("joke") || input.Contains("jokes") || input.Contains("tell me a joke"))
                return $"Hoot! Here's a joke for you: {jokes[random.Next(jokes.Count)]}";

            // random study tip
            if (input.Contains("study tip") || input.Contains("study tips") || input.Contains("how to study"))
                return $"Hoot! Here's a study tip for you: {studyTips[random.Next(studyTips.Count)]}";

            input = input.ToLower();
            string match = "";

            match = matchCourse(input);
            if (match != null) return match;

            match = matchStudentData(input);
            if (match != null) return match;

            match = matchEnrolledCourses(input);
            if (match != null) return match;

            match = matchPreviousCourses(input);
            if (match != null) return match;

            

            return "Hoot! I am having trouble finding an answer to your question. Sorry!";
        }
    }
}
