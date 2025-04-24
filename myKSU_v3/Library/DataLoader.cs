using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Data.Common;
using System.Runtime.CompilerServices;
using myKSU_v3;

namespace myKSU_v3.Library
{
    public static class DataLoader
    {
        // !!! DO NOT EDIT !!!
        private static readonly string basepath = Path.Combine(AppContext.BaseDirectory, "data");

        // !!! JSON SERIALIZER OPTIONS - DO NOT EDIT !!!
        private static JsonSerializerOptions JsonOptions => new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };


        //
        // Read json data for any object type, json key names must match class fields EXACTLY, filepathing is dynamic
        //
        private static T LoadFromJson<T>(string filename)
        {
            try
            {
                // Ensure data directory exists
                if (!Directory.Exists(basepath))
                    throw new DirectoryNotFoundException($"Data directory missing: {basepath}");

                // Resolve file path dynamically
                string filepath = Path.Combine(basepath, filename);

                if (!File.Exists(filepath))
                    throw new FileNotFoundException($"JSON file not found: {filepath}");

                // Read JSON file
                string json = File.ReadAllText(filepath);

                // Deserialize JSON with options
                return JsonSerializer.Deserialize<T>(json, JsonOptions)
                       ?? throw new InvalidDataException($"Failed to deserialize JSON: {filepath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading JSON: {ex.Message}");
                throw; // Rethrow exception for further handling
            }
        }
        

        //
        // CREATE OBJECTS VIA READING JSON FILES
        //
        public static Student LoadStudent() 
        { 
            var student = new Student();  // create reference to object to pass to other forms
            return LoadFromJson<Student>("student.json"); 
        }
        public static CourseManager LoadCourseManager()
        {
            var courseManager = new CourseManager();
            courseManager.catalogFall2026 = LoadFromJson<List<Course>>("catalog.json"); // catalogFall2026 = list of Course objs
            return courseManager;
        }
        public static University LoadUniversity()
        {
            var university = LoadFromJson<University>("university.json");
            return university;
        }
        public static ChargeAccount LoadChargeAccount()
        {
            var chargeAccount = new ChargeAccount();
            return LoadFromJson<ChargeAccount>("chargeAccount.json");
        }
        public static Profile LoadProfile()
        {
            var profile = new Profile();
            return LoadFromJson<Profile>("profile.json");
        }


        //
        // UPDATE STUDENT JSON FILE
        //
        public static void SaveStudentData(Student student)
        {
            string filepath = Path.Combine(basepath, "student.json");  // use basepath field to get file

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };

            try
            {
                string jsonString = JsonSerializer.Serialize(student, options);
                File.WriteAllText(filepath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update student data.\nERROR: {ex.Message}");
            }
        }


        // 
        // UPDATE CHARGEACCOUNT JSON FILE
        //
        public static void SaveChargeAccountData(ChargeAccount chargeAccount)
        {
            string filepath = Path.Combine(basepath, "chargeAccount.json");

            var options = new JsonSerializerOptions 
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };

            try
            {
                string jsonString = JsonSerializer.Serialize(chargeAccount, options);
                File.WriteAllText(filepath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update charges data.\nERROR: {ex.Message}");
            }
        }


        //
        // UPDATE PROFILE JSON FILE
        //
        public static void SaveProfileData(Profile profile)
        {
            string filepath = Path.Combine(basepath, "profile.json");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };

            try
            {
                string jsonString = JsonSerializer.Serialize(profile, options);
                File.WriteAllText(filepath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update profile data.\nERROR: {ex.Message}");
            }
        }
    }
}