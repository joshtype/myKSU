using System;
using myKSU_v3;

namespace myKSU_v3.Library
{
    public class BotReplyManager
    {
        private Student student;
        private CourseManager courseManager;
        private University university;
        
        public BotReplyManager(University university, Student student, CourseManager courseManager)
        {
            this.university = university;
            this.student = student;
            this.courseManager = courseManager;
        }


        //
        // LISTS TO DETERMINE QUERY TYPE
        //
        private readonly List<string> universityKeywords = new List<string>
        {
            "university", "ksu", "campus", "semester", "address", "add/drop", "add drop", "deadline"
        };
        private readonly List<string> officeKeywords = new List<string>()
        {
            "admissions", "financial", "aid", "bursars", "registrar", "registration", "advising", "library", "cafeteria", "uits", "technical", "tech", "police", "health"
        };        
        private readonly List<string> studentKeywords = new List<string>
        {
            "id", "my name", "gpa", "standing", "birthday", "dob", "schedule", "enrolled", "current courses", "my courses", "previous courses", "taken"
        };


        //
        // MATCH QUERY TO CORRECT REPLY METHOD
        //
        public string? DefineReply(string query)
        {
            query = query.ToLower();

            if (universityKeywords.Any(keyword => query.Contains(keyword)))
                return GetUniversityReply(query);

            if (studentKeywords.Any(keyword => query.Contains(keyword)))
                return GetStudentReply(query);
        
            if (officeKeywords.Any(keyword => query.Contains(keyword)))
                return GetOfficeReply(query);

            if (query.Contains("joke"))
                return GetJokeReply();

            if (query.Contains("study") || query.Contains("tip"))
                return GetStudyTipReply();

            if (query.Contains("help") || query.Contains("how to"))
                return GetHelpReply();

            return null;
        }

        // REPLISE: QUERIES ABOUT BASIC KSU DATA
        public string? GetUniversityReply(string query)
        {
            if (university == null)
                return null;

            query = query.ToLower();

            if (query.Contains("name"))
                return $"Hoot! KSU's full name is {university.name}. KSU was named after Kennesaw Mountain. It offers spectacular views, great hiking trails, and intense updrafts (wings required)!";
            if (query.Contains("campus"))
                return $"Hoot! This the university's {university.campus}. Aren't the trees lovely?";

            if (query.Contains("address"))
                return $"Hoot! KSU's main address is {university.address}. I love this town. Especially the trees!";

            if (query.Contains("semester"))
                return $"Hoot! The current semster you can register for is {university.semester}. The sooner you get started, the better!";

            if (query.Contains("deadline") || query.Contains("drop"))
                return $"Hoot! The add/drop deadline is {university.addDropDeadline}. Remember to register all your classes in time!";

            return null; // no matching university fields found for input keyword
        }


        //
        // REPLIES: QUERIES ABOUT SPECIFIC KSU OFFICES 
        //
        public string? GetOfficeReply(string query)
        {
            if (university.offices == null || university.offices.Count == 0)
                return null;

            query = query.ToLower(); 

            // Check for office name match
            foreach (var key in university.offices.Keys)
            {
                if (query.Contains(key.ToLower())) 
                    return university.offices[key].ToString(); 
            }

            return null; // no matching office fields found for input keyword
        }


        //
        // REPLIES: QUERIES ABOUT STUDENT
        //
        public string? GetStudentReply(string query)
        {
            if (student == null)
                return null;

            query = query.ToLower();

            if (query.Contains("name"))
                return $"Your name stored in KSU records is {student.name}";

            if (query.Contains("id"))
                return $"Your KSU ID is {student.ksuId}. Keep it secret. Keep it safe.";

            if (query.Contains("dob") || query.Contains("birth"))
                return $"Your birthday is {student.dob}. Happy early or late bday!";

            if (query.Contains("major"))
                return $"Your majoring in {student.major}. Great choice!";

            if (query.Contains("gpa"))
                return $"Your current GPA is {student.gpa}.You got this!";

            if (query.Contains("standing"))
                return $"Your class standing is {student.standing}. Almost there!";

            if (query.Contains("enrolled") || query.Contains("current courses"))
            {
                if (student.enrolledCourses == null || student.enrolledCourses.Count == 0)
                    return "You are not currently enrolled in any courses.";

                return "Your enrolled courses:\n" + string.Join("\n• ", student.enrolledCourses.Select(c => c.ToString() + "\n"));
            }

            if (query.Contains("previous") || query.Contains("past courses"))
            {
                if (student.previousCourses == null || student.previousCourses.Count == 0)
                    return "No previous course data available.";

                return "Your have taken \n" + string.Join("\n• ", student.enrolledCourses.Select(c => c.ToString()));
            }
            return null; // no matching keyword found for student data
        }


        //
        // REPLIES: RANDOM JOKES
        //
        public string GetJokeReply()
        {
            List<string> jokes = new List<string>
            {
                "Why did the student eat his homework? Because his teacher told him it was a piece of cake!",
                "Parallel lines have so much in common. It’s a shame they’ll never meet!",
                "Why do programmers prefer dark mode? Because light attracts bugs!",
                "Why did the calculus book look so sad? Because it had too many problems!",
                "Math teachers have too many functions, but they still find time to solve problems!",
                "How do robots diet? Less bytes!"
            };
            Random rand = new Random();
            return "This one is a hoot! " + jokes[rand.Next(jokes.Count)];
        }


        //
        // REPLIES: RANDOM STUDY TIPS
        //
        public string GetStudyTipReply()
        {
            List<string> studyTips = new List<string>
            {
                "Use the Pomodoro technique: Study for 25 minutes, then take a 5-minute break!",
                "Create flashcards to reinforce key concepts and improve memory recall.",
                "Teach the material to someone else — it’s a great way to solidify your understanding!",
                "Avoid distractions: Put your phone on silent and focus completely for a set time.",
                "Get enough sleep! Studies show that a well-rested brain retains information better.",
                "Studying a little each day - instead of cramming at the last minute - improves retention."
            };
            Random rand = new Random();
            return "Hoot! Here's a good tip: " + studyTips[rand.Next(studyTips.Count)];
        }


        //
        // REPLIES: USER HELP 
        //
        public string GetHelpReply()
        {
            string helpReply = "Hoot! I can answer questions about KSU, KSU offices, and you!\nAsk me about your gpa, current and previous courses, office contact info, etc." +
                "\nYou can use questions or keywords (eg: 'GPA', 'enrolled courses'. If I don't have an answer, try rewording!" +
                "\nIf needed, you can always contact UITS for tech support!";
            return helpReply;
        }
    }
}
