using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Customer
    {
        // Primary Key
        public int CustomerId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidThrough { get; set; }
        public DateTime LastUpdate { get; set; }

        // Foreign Keys
        public virtual Address Address { get; set; }
        public virtual Password Password { get; set; }

        // TODO: FIX
        //public virtual List<Report> Reports { get; set; }
        //public virtual List<Bill> Bills { get; set; }
    }
}
