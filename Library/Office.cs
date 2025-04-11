using System;

namespace myKSU_v3.Library
{
    public class Office
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string hours { get; set; }
        public string location { get; set; }

        public override string ToString() { return $"{name}: {location} ({phone})"; }
    }
}