using System;
using myKSU_v3;

namespace myKSU_v3.Library
{
    public class Office
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string hours { get; set; }
        public string location { get; set; }

        public override string ToString() { return $"{this.name}: {this.phone} / {this.hours} / {this.location}."; }
    }
}