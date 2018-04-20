using System;

namespace Data.Entities
{
    public class Bill
    {
        //Primary key
        public int BillId { get; set; }

        public float Amount { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime LastUpdate { get; set; }

        // Foreign Keys
        public virtual Customer Customer { get; set; }
    }
}