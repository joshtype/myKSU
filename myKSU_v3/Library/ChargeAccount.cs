using System;
using System.Security.Cryptography.X509Certificates;
using myKSU_v3;

namespace myKSU_v3.Library
{
    public class ChargeAccount
    {
        public string ksuId          { get; set; }
        public string accountNumber  { get; set; }
        public decimal totalPaid     { get; set; }
        public decimal totalUnpaid   { get; set; }
        public List<Charge> charges  { get; set; } = new();

        public List<Charge> unpaidCharges;
        public List<Charge> paidCharges;

        public ChargeAccount() 
        {
            this.charges = new List<Charge>();
        }


        //
        // GET LIST OF UNPAID CHARGES
        //
        public List<Charge> GetUnpaidCharges()
        {
            return this.charges.Where(c => c.isPaid == false).ToList();
        }


        //
        // GET LIST OF PAID CHARGES
        //
        public List<Charge> GetPaidCharges()
        {
            return this.charges.Where(c => c.isPaid == true).ToList();
        }


        //
        // GET SUM OF PAID CHARGES
        //
        public decimal SumPaidCharges()
        {
            decimal sum = 0;
            foreach(Charge charge in this.GetPaidCharges())
            {
                sum += charge.amount;
            }
            return sum;
        }

        
        //
        // GET SUM OF UNPAID CHARGES
        //
        public decimal SumUnpaidCharges()
        {
            decimal sum = 0;
            foreach (Charge charge in this.charges)
            {
                if (!charge.isPaid) sum += charge.amount;
            }
            return sum;
        }
    }
}
