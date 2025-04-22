using System;
using myKSU_v3;

namespace myKSU_v3.Library
{
    public class Profile
    {
        public Student student;
        public string url { get; set; }
        public string interests { get; set; }
        public string favQuote { get; set; }
        public string bio { get; set; }

        public override string ToString()
        {
            return $"{student.name}'s profile: \nWebsite: {url} \nInterests: {interests} \nFavorite Quote: {favQuote}";
        }
    }
}
