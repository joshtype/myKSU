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
        // GET LIST OF PAID AND UNPAID CHARGES
        //
        public List<Charge> getUnpaidCharges()
        {
            return this.charges.Where(c => c.isPaid == false).ToList();
        }
        public List<Charge> getPaidCharges()
        {
            return this.charges.Where(c => c.isPaid == true).ToList();
        }

        //
        // GET SUM OF PAID AND UNPAID CHARGES
        //
        public decimal sumPaidCharges()
        {
            decimal sum = 0;
            foreach(Charge charge in this.getPaidCharges())
            {
                sum += charge.amount;
            }
            return sum;
        }
        public decimal sumUnpaidCharges()
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
