using Microsoft.VisualBasic.Devices;
using System.IO;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Runtime;

namespace myKSU.Models
{
    public class PaymentActivity
    {
        private String paymentId        { get; set; }
        private DateOnly? dueDate       { get; set; }
        private double amount           { get; set; }
        private String paymentMethod    { get; set; }
        private String status           { get; set; }
        private DateOnly datePaid       { get; set; }
        private String description      { get; set; }

        public PaymentActivity()
        {
            String filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "paymentData.json");
        }
    }
}