using System;

namespace Application.ViewModels
{
    public class BillViewModel
    {
        public int BillId { get; set; }
        public float Amount { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}