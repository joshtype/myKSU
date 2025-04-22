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
        public DateOnly? paidDate     { get; set; }  
        public string? paymentId      { get; set; }

        public string paidDateFormatted => paidDate?.ToString("yyyy-MM-dd") ?? " ";
    }
}

