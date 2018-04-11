using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Contract
    {
        //primary key
        public int ContractId { get; set; }

        public string Description { get; set; }
        public string ContractNotification { get; set; }

        public DateTime LastUpdate { get; set; }
    }
}
