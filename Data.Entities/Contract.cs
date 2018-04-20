using System;

namespace Data.Entities
{
    public class Contract
    {
        //primary key
        public int ContractId { get; set; }

        public string Description { get; set; }
        public string ContractStatus { get; set; }
        public DateTime LastUpdate { get; set; }

        // Foreign Keys
        public virtual Customer Customer { get; set; }
    }
}