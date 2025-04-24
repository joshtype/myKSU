using System;
using System.Security.Cryptography.X509Certificates;
using myKSU_v3;

namespace myKSU_v3.Library
{
    public class Charge
    {
        public decimal amount         { get; set; }
        public DateOnly dueDate       { get; set; }
        public string description     { get; set; }
        public bool isPaid            { get; set; } = false;  // default = false
        public string? paymentMethod  { get; set; }
        public string? paymentId      { get; set; }

        public string paidDate { get; set; } = "N/A"; // should be nullable DateOnly, display issues force non-nullable string set to default
    }
}

