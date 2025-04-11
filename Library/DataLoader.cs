using myKSU_v3.Models;
using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace myKSU_v3.Library
{
    public static class DataLoader
    {
        // Fetches filepath dynamically
        private static readonly string basepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");

        private static JsonSerializerOptions Options => new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };

        // Reads data from json to populate fields for any object type  
        private static T loadFromJson<T>(string filename)
        {
            string filepath = Path.Combine(basepath, filename);

            if (!File.Exists(filepath)) throw new FileNotFoundException($"Missing JSON file at {filepath}");
            
            string json = File.ReadAllText(filepath);

            return JsonSerializer.Deserialize<T>(json, Options);
        }

        // Creates objects via loadFromJson<T>()
        public static Student loadStudent() { return loadFromJson<Student>("student.json"); }
        public static CourseManager loadCourseManager()
        {
            var courseManager = new CourseManager();
            courseManager.catalogFall2026 = loadFromJson<List<Course>>("courseCatalog.json");
            return courseManager;
        }
        public static University loadUniversity()
        {
            var university = loadFromJson<University>("university.json");
            return university;
        }
    }
}

