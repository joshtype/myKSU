using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace myKSU_v3.Library
{
    public static class DataLoader
    {
        //
        // Configure Json serializer
        //
        private static JsonSerializerOptions Options => new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };

        //
        // Fetch filepath dynamically & read json data for any object type
        //
        private static readonly string basepath = Path.Combine(Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName, "data");
        private static T loadFromJson<T>(string filename)
        {
            string filepath = Path.Combine(basepath, filename);

            if (!File.Exists(filepath)) throw new FileNotFoundException($"Missing JSON file at {filepath}");

            string json = File.ReadAllText(filepath);

            return JsonSerializer.Deserialize<T>(json, Options);
        }

        //
        // Create Student, CourseManager, University objects via loadFromJson()
        //
        public static Student loadStudent() 
        { 
            // create reference to object to pass to other forms
            var student = new Student();
            return loadFromJson<Student>("student.json"); 
        }
        public static CourseManager loadCourseManager()
        {
            // catalogFall2026 = list of Courses from Json, acts as a catalog, use to get/search courses
            var courseManager = new CourseManager();
            courseManager.catalogFall2026 = loadFromJson<List<Course>>("catalog.json");
            return courseManager;
        }
        public static University loadUniversity()
        {
            var university = loadFromJson<University>("university.json");
            return university;
        }
    }
}