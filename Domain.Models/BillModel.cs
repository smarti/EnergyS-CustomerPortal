using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
