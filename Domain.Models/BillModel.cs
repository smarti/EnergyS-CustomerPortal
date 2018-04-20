using System;

namespace Domain.Models
{
    public class BillModel
    {
        public int BillId { get; set; }
        public float Amount { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}